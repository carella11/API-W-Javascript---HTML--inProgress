using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrimitOppg.Controllers.Model;

namespace TrimitOppg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class API1 : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<Song> GetOne(int id)
        {
            return await Task.Run(() =>
                new Song() { Id = id, Artist = "Flume", Name = "Ezra" }
            );
        }
        [HttpGet]
        public async Task<IEnumerable<Song>> GetMany()
        {
            return await Task.Run(() => new[]
                {
                    new Song() { Id = 1, Artist = "J. Cole", Name = "Lights Please" },
                    new Song() { Id = 2, Artist = "Kojey Radical", Name = "Water" }
                }
            );
        }
        [HttpPost]
        public async Task<int> Create(Song song)
        {
            return await Task.Run(() => 1);
        }
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await Task.Run(() => 1);
        }
    }
}
