using List.Tasks.Models;
using List.Tasks.Services.Data;
using List.Tasks.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Tasks.Services
{
    public class AuthorService : IAuthorService
    {
        List<Author> IAuthorService.GetAll()
        {
            return AppDbContext.Authors();
        }

        List<Author> IAuthorService.GetByAge(int age)
        {
            return AppDbContext.Authors();
        }
    }



}
