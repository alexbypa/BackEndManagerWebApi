using Asp.Versioning;
using Flurl.Util;
using Microsoft.AspNetCore.Mvc;

namespace BackEndManagerWebApi.Controllers.oop {
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class DesignPatternsController : Controller {
        [HttpGet(Name = "chainofresponsability")]
        [MapToApiVersion("2.0")]
        public async Task<IActionResult> chainofresponsability(string username, string password) {
            var authentication = new AuthenticationHandler();
            var authorization = new AuthorizationHandler();

            authentication.SetNext(authorization);
            authentication.HandleResponse(new oop.Request { UserName = username, Password = password });
            return Ok();
        }
    }

    public class Request {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string ErrorMessage { get; set; }
    }
    public interface IResponseHandler {
        void SetNext(IResponseHandler handler);
        void HandleResponse(Request request);
    }

    public class ResponseBaseHandler : IResponseHandler {
        protected IResponseHandler _nextHandler;
        private bool canPatternRun = true;
        public virtual void HandleResponse(Request request) {
            if (!string.IsNullOrEmpty(request.ErrorMessage))
                Console.WriteLine(request.ErrorMessage);
            else if (_nextHandler != null)
                _nextHandler.HandleResponse(request);
        }
        public virtual void SetNext(IResponseHandler handler) {
            _nextHandler = handler;
        }
        protected virtual void RunException(Exception ex) {
            Console.WriteLine("[ERR] " + ex.ToString());
        }
    }
    public class AuthenticationHandler : ResponseBaseHandler {
        public override void HandleResponse(Request request) {
            Console.WriteLine($"Request handled by AuthenticationHandler. {request.UserName}");
            if (request.UserName != "admin")
                request.ErrorMessage = "User isnt admin";
            base.HandleResponse(request);
        }
        public override void SetNext(IResponseHandler nextHandler) {
            base.SetNext(nextHandler);
        }
    }
    public class AuthorizationHandler : ResponseBaseHandler {
        public override void HandleResponse(Request request) {
            Console.WriteLine("Request handled by AuthorizationHandler.");
            if (request.UserName == "error") {
                RunException(new Exception("Errore di prova "));
            }
            base.HandleResponse(request);
        }
        public override void SetNext(IResponseHandler nextHandler) {
            base.SetNext(nextHandler);
        }
    }
}
