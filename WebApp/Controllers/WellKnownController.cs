using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class WellKnownFileController : Controller
    {
        public WellKnownFileController()
        {

        }

        private string Path(string id) => System.IO.Path.GetFullPath($".well-known/acme-challenge/{id}");

        [Route(".well-known/acme-ping/{id}")]
        public ContentResult AcmePing(string id)
        {
            return new ContentResult
            {
                Content = Path(id),
                ContentType = "text/text"
            };
        }

        [Route(".well-known/acme-challenge/{id}")]
        public ContentResult AcmeChallenge(string id)
        {
            return new ContentResult
            {
                Content = System.IO.File.ReadAllText(Path(id)),
                ContentType = "text/text"
            };
        }
    }
}