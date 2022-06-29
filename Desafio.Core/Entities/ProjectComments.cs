using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Core.Entities
{
    public class ProjectComments : BaseEntity
    {
        public ProjectComments(string content, int idProject, int idUser)
        {
            Content = content;
            IdProject = idProject;
            IdUser = idUser;
        }

        public string Content { get; private set; }
        public int IdProject { get; private set; }
        public int IdUser { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
