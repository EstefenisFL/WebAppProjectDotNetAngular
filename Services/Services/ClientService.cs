﻿using Domain.Models;
using ProjectWebData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Services.Services
{
    public class ClientService : ServiceBase<ClientDTO>, IClientService
    {
        public readonly IRepositoryClient _repositoryClient;
        public ClientService(IRepositoryClient repositoryClient) : base(repositoryClient)
        {
            _repositoryClient = repositoryClient;
        }
        
        public void AddClient(ClientDTO newClient)
        {
            _repositoryClient.AddClient(newClient);
        }
        override
        public ClientDTO GetById(int id)
        {
            return _repositoryClient.GetById(id);
        }
        public IEnumerable<ClientDTO> FindClients()
        {
            return _repositoryClient.GetAllClients();
        }
        override
        public void Update(ClientDTO obj)
        {
            _repositoryClient.Update(obj);
        }
        override
        public void Remove(ClientDTO obj)
        {
            _repositoryClient.Remove(obj);
        }
    }
}
