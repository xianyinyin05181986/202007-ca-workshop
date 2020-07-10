using CaWorkshop.Application.TodoLists.Commands.CreateTodoList;
using CaWorkshop.Infrastructure.Persistence;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CaWorkshop.Application.UnitTests.TodoLists.Commands.CreateTodoList
{

    public class CreateTodoListCommandTests : TestFixture
    {
        private readonly ApplicationDbContext _context;

        public CreateTodoListCommandTests()
        {
            _context = Context;
        }

        // 🔥 Code omitted for clarity 🔥
    }
}