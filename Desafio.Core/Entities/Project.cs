using Desafio.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreelance, decimal totalCoast)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelance = idFreelance;
            TotalCoast = totalCoast;
            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<ProjectComments>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelance { get; private set; }
        public decimal TotalCoast { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComments> Comments { get; private set; }
    }
}
