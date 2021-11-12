using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Product[]
            {
                new Product { Id = 1, Type = "Phone", Model = "OnePlus", Price = 1000 },
                new Product { Id = 2, Type = "Phone", Model = "Apple", Price = 2000 },
                new Product { Id = 3, Type = "Phone", Model = "Samsung", Price = 1500 },
                new Product { Id = 4, Type = "TV", Model = "Samsung 32", Price = 200 },
                new Product { Id = 5, Type = "TV", Model = "Samsung 64", Price = 2000 },
                new Product { Id = 6, Type = "TV", Model = "Samsung 64 OLED", Price = 7000 },
                new Product { Id = 7, Type = "Car", Model = "VW Golf", Price = 30000 },
                new Product { Id = 8, Type = "Car", Model = "VW Passat", Price = 60000 },
                new Product { Id = 9, Type = "Car", Model = "Audi A8", Price = 120000 }
            };

            var people = new Person[]
            {
                new Person { Id = 1, Name = "Ivan Ivanov", Money = 150000 },
                new Person { Id = 2, Name = "Dragan Draganov", Money = 250000 },
                new Person { Id = 3, Name = "Ivelin Ivelinov", Money = 350000 }
            };

            var items = new Item[]
            {
                new Item { PersonId = 1, ProductId = 1, Amount = 1 },
                new Item { PersonId = 1, ProductId = 4, Amount = 1 },
                new Item { PersonId = 1, ProductId = 5, Amount = 1 },
                new Item { PersonId = 1, ProductId = 7, Amount = 1 },
                new Item { PersonId = 2, ProductId = 2, Amount = 1 },
                new Item { PersonId = 2, ProductId = 6, Amount = 1 },
                new Item { PersonId = 2, ProductId = 7, Amount = 1 },
                new Item { PersonId = 2, ProductId = 9, Amount = 1 },
                new Item { PersonId = 3, ProductId = 3, Amount = 1 },
                new Item { PersonId = 3, ProductId = 8, Amount = 1 },
                new Item { PersonId = 3, ProductId = 7, Amount = 1 }
            };


            var result1 = people.GroupJoin(items,
                person => person.Id,
                item => item.PersonId,
                (person, personItems) => new
                {
                    Person = person,
                    Products = personItems.Join(products,
                        item => item.ProductId,
                        product => product.Id,
                        (item, product) => product
                    ).ToArray()
                }
            ).ToArray();

            var result2 = people.GroupJoin(items,
                    person => person.Id,
                    item => item.PersonId,
                    (person, personItems) => new
                    {
                        Person = person,
                        Products = personItems.Join(products,
                                item => item.ProductId,
                                product => product.Id,
                                (item, product) => product
                            )
                            .Select(product => $"Product type {product.Type}, model: {product.Model}")
                            // .DefaultIfEmpty()
                            .Aggregate((f, s) => f + Environment.NewLine + s)
                            .ToArray()
                    }
                )
                .Select(personProduct =>
                    $"Person: {personProduct.Person.Name}{Environment.NewLine} Product{personProduct.Products}")
                .Aggregate((f, s) => f + Environment.NewLine + s);

            var result3 = people.Select(person => new
                {
                    Person = person,
                    Product = items
                        .Where(item => item.PersonId == person.Id)
                        .Select(item => products
                            .Where(product => product.Id == item.ProductId)
                            .Single())
                        .ToArray()
                })
                .ToArray();

            var result4 = people.Select(person => new
            {
                Person = person,
                Value = person.Money +
                        items.Where(item => item.PersonId == person.Id)
                            .Select(item => products.Where(product => product.Id == item.ProductId)
                                .Select(product => product.Price * item.Amount)
                                .Single())
                            .Aggregate((f, s) => f + s)
            }).ToArray();
        }
    }
}