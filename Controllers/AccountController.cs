using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewCo.Controllers.Resources;
using NewCo.Core.Models;
using NewCo.Core;

namespace NewCo.Controllers
{
    [Route("/api/accounts")]
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly IAccountRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public AccountController (IMapper mapper, IAccountRepository repository, IUnitOfWork unitOfWork) {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccount(int id) {
            var account = await repository.GetAccount(id);

            if (account == null)
                return NotFound();

            var accountResource = mapper.Map<Account, AccountResource>(account);
            
            return Ok(accountResource);
        }
    }
}