using System.Threading.Tasks;
using BuildStoreEnterprise.WebApp.MVC.Models;

namespace BuildStoreEnterprise.WebApp.MVC.Services
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);

        Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro);
    }
}