using WebApplicationAPP.Data;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        ///Declarar nuestras funciones por ejemplo
        /////CRUD
        ///
        private readonly AppDbContext _context;
        public PersonaRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Persona> GetAllPersonas()
        {
            return _context.Persona.ToList();
        }
        public Persona GetPersonaById(int id)
        {
            return _context.Persona.Find(id);
        }

        public void AddPersona(Persona persona)
        {
            _context.Persona.Add(persona);
            _context.SaveChanges();
        }

        public void UpdatePersona(Persona persona)
        {
            _context.Persona.Update(persona);
            _context.SaveChanges();

            //var existingPersona = _context.Personas.FirstOrDefault(p => p.Id == persona.Id);
            //if (existingPersona != null)
            //{
            //    existingPersona.Nombre = persona.Nombre;
            //    existingPersona.Apellido = persona.Apellido;
            //    existingPersona.Estado = persona.Estado;
            //    _context.SaveChanges();
            //}
            _context.Persona.Update(persona);
            _context.SaveChanges();
        }
        

        public void DeletePersona(int id)
        {
            var persona = GetPersonaById(id);
            if (persona != null)
            {
                _context.Persona.Remove(persona);
                _context.SaveChanges();
            }
        }

        //List<Persona> GetAllPersonas();
        //Persona GetPersonaById(int id);
        //void AddPersona(Persona persona);
        //void UpdatePersona(Persona persona);
        //void DeletePersona(int id);



    }
}