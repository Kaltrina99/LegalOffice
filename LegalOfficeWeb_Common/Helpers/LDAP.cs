using Microsoft.Extensions.Options;
using Novell.Directory.Ldap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Common.Helpers
{
    public class LdapConfig
    {
        public string Url { get; set; }
        public string UrlKesco { get; set; }
        public string BindDn { get; set; }
        public string BindCredentials { get; set; }
        public string SearchBase { get; set; }
        public string SearchBaseKesco { get; set; }
        public string SearchFilter { get; set; }
        public string AdminCn { get; set; }
        public string Secret { get; set; }
    }
    public interface IAuthenticationService
    {
        LdapEntry LDAPLogin(string username, string password);
    }

    public class LdapAuthenticationService : IAuthenticationService
    {
        private const string MemberOfAttribute = "memberOf";
        private const string DisplayNameAttribute = "displayName";
        private const string SAMAccountNameAttribute = "sAMAccountName";

        private readonly LdapConfig _config;
        private enum CompanyDomain
        {
            KEDS = 1,
            KESCO = 2
        }

        public LdapAuthenticationService(IOptions<LdapConfig> config)
        {
            _config = config.Value;
        }

        public LdapEntry LDAPLogin(string username, string password)
        {
            var domain = username.ToLower().StartsWith("keds") ? CompanyDomain.KEDS : CompanyDomain.KESCO;
            try
            {
                using (var cn = new LdapConnection())
                {
                    var url = domain == CompanyDomain.KEDS ? _config.Url : _config.UrlKesco;
                    var searchBase = domain == CompanyDomain.KEDS ? _config.SearchBase : _config.SearchBaseKesco;
                    var usrn = domain == CompanyDomain.KEDS ? "KEDS\\" + username : "KESCO\\" + username;

                    cn.Connect(url, LdapConnection.DefaultPort);
                    cn.Bind(usrn, password);
                    var searchFilter = string.Format(_config.SearchFilter, username);
                    var result = cn.Search(
                        searchBase,
                        LdapConnection.ScopeSub,
                        searchFilter,
                        new[] { MemberOfAttribute, DisplayNameAttribute, SAMAccountNameAttribute },
                        false
                    );
                    var user = result.Next();
                    return user;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
