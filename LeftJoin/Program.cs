using LeftJoin;

List<Persona> persona = new List<Persona>();
List<Colegio> colegio = new List<Colegio>;

from p in persona

join co in colegio
from pco in PersonasColegio.DefaultIfEmpty()
select new
{
    //lo que quieras seleccionar, por ejemplo codPersona = p.CodPersona,
}