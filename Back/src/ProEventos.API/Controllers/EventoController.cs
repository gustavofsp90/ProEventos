using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() {
                EventoId = 1,
                Local = "Belo Horizonte",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular 11",
                QtdPessoas = 250,
                Lote = "1º Lote",
                ImagemURL = "Foto.Png"   
                },            
                new Evento() {
                EventoId = 2,
                Local = "Sao Paulo",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular 11 e Novidades",
                QtdPessoas = 350,
                Lote = "2º Lote",
                ImagemURL = "Foto1.Png"   
                } 
            };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;              
            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetbyId(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);              
            
        }

        [HttpPost]
        public string Post()
        {
            return "Example de post";
        }

        [HttpPut("{id}")]
        public string Put()
        {
            return "Example de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete()
        {
            return "Example de Delete com id = {id}";
        }
    }
}
