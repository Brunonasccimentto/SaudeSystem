using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ControladorDePedidos.Filters
{
    public class ExceptionHandler(ILogger<ExceptionHandler> filter) : IExceptionFilter
    {
        private readonly ILogger<ExceptionHandler> _filter = filter;

        public void OnException(ExceptionContext context)
        {
            _filter.LogError(context.Exception, $"Ocorreu uma exceção não tratada. \n\n Message: {context.Exception.Message}");

            context.Result = new ObjectResult($"Ocorreu um problema ao tratar a sua solicitação. StatusCode: {StatusCodes.Status500InternalServerError}"){
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
        
    }
}