using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

/*
 * Forma Sincrona, lo que hace la forma sincrona es hacer la peticion en un hilo por lo cual ese hilo
 * no se puede soltar hasat que termine esa peticion.
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers(){
            // Nos devobera una lista de los usuarios

            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id){
            // En este caso solo nos va a debolver un usuario.

            return _context.Users.Find(id);
        }
*/
/*
 * Forma Asincrona, y podemos decirle al hilo es que cuando vaya a la base de datos,
 * pase esta solicitud a otro hilo, que ese hilo se encargará de obtener los datos.
 * Pero mientras tanto, si alguien más llega a este punto, voy a atender esa solicitud.
 * Y si también quieren algo de la base de datos, también lo pasaré a otro hilo.

 * Basicamente lo que hace la programacion asincrona es no esperar a que se finalize un proceso
 * para poder obtener otra solicutud

 * Para ello lo que tenemos que hacer es poner public async, luego envolvemos la devolucion 
 * en una tarea (Task<>), ahora lo que tenemos que decirle a esa linea de codigo que tenemos que esperar
 * y eso se hace con la palabra clave awit, el metodo de debolucion tambien tiene que ser Asincrono
*/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            // Nos devobera una lista de los usuarios

            return await  _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id){
            // En este caso solo nos va a debolver un usuario.

            return await _context.Users.FindAsync(id);
        }
    }
}