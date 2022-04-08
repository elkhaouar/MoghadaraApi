using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moghadara.Bll.ServiceAbstractions;
using Moghadarate.Domain.Models;

namespace MoghadaraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FonctionnaireController : ControllerBase
    {
        IServices<Fonctionnaire> service;

        public FonctionnaireController(IServices<Fonctionnaire> service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetAll());
        }
        [HttpGet ("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(service.GetById(id));
        }
        [HttpPost]
        public void Post(Fonctionnaire model)
        {
            service.Post(model);
        }
        [HttpPut("{id}")]
        public void Put(Fonctionnaire model, int id)
        {
            service.Put(model,id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
