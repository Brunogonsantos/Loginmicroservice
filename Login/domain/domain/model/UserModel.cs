using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.domain.model
{
    public class UserModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public EnderecoModel Endereco { get; set; }
    }
}
