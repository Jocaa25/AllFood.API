using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } // Armazenar o hash da senha, não a senha em texto puro

        // Informações relacionadas à autenticação e autorização
        public string RefreshToken { get; set; } // Pode ser usado para renovar tokens de acesso
        public DateTime RefreshTokenExpiration { get; set; } // Data de expiração do refresh token
        public bool IsAdmin { get; set; } // Indica se o usuário tem privilégios de administrador

        // Outros atributos relacionados aos usuários, se necessário
    }
}
