using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TrackableEntities.Common;
using TrackableWebApi.Entities.Shared.Net45;
using TrackableWebApi.Service.Persistence.Exceptions;
using TrackableWebApi.Service.Persistence.UnitsOfWork;

namespace TrackableWebApi.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        // TODO: Rename IExampleUnitOfWork to match Unit of Work Interface added to Persistence project
        private readonly INorthwindUnitOfWork _unitOfWork;

        // TODO: Rename IExampleUnitOfWork parameter
        public CustomerController(INorthwindUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/Customer
        [ResponseType(typeof(IEnumerable<Customer>))]
        public async Task<IHttpActionResult> GetCustomers()
        {
            IEnumerable<Customer> entities = await _unitOfWork.CustomerRepository.GetCustomers();
            return Ok(entities);
        }

        // GET api/Customer/5
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> GetCustomer(string id)
        {
            Customer entity = await _unitOfWork.CustomerRepository.GetCustomer(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        // POST api/Customer
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> PostCustomer(Customer entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.CustomerRepository.Insert(entity);

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (UpdateException)
            {
                if (_unitOfWork.CustomerRepository.Find(entity.CustomerID) == null)
                {
                    return Conflict();
                }
                throw;
            }

            await _unitOfWork.CustomerRepository.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();

            return CreatedAtRoute("DefaultApi", new { id = entity.CustomerID }, entity);
        }

        // PUT api/Customer
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> PutCustomer(Customer entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.CustomerRepository.Update(entity);

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (UpdateConcurrencyException)
            {
                if (_unitOfWork.CustomerRepository.Find(entity.CustomerID) == null)
                {
                    return Conflict();
                }
                throw;
            }

            await _unitOfWork.CustomerRepository.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/Customer/5
        public async Task<IHttpActionResult> DeleteCustomer(string id)
        {
            bool result = await _unitOfWork.CustomerRepository.DeleteCustomer(id);
            if (!result) return Ok();

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (UpdateConcurrencyException)
            {
                if (_unitOfWork.CustomerRepository.Find(id) == null)
                {
                    return Conflict();
                }
                throw;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                var disposable = _unitOfWork as IDisposable;
                if (disposable != null)
                    disposable.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
