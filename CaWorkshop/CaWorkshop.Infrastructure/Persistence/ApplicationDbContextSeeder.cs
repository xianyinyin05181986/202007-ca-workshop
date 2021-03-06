﻿using CaWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaWorkshop.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.TodoLists.Any())
            {
                return;
            }

            var list = new TodoList
            {
                Title = "Death List Five",
                Items =
                {
                    new TodoItem { Title = "O-Ren Ishii", Done = true },
                    new TodoItem { Title = "Vernita Green", Done = true },
                    new TodoItem { Title = "Budd", Done = true },
                    new TodoItem { Title = "Ellie Driver" },
                    new TodoItem { Title = "Bill" }
                }
            };

            context.TodoLists.Add(list);
            context.SaveChanges();
        }
    }
}
