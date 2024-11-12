using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk
{
    public struct CallerId
    {
        public string? user {  get; set; }

        public string? name { get; set; }

        public string? tech { get; set; }

        public string? domain { get; set; }

        public int? port { get; set; }

        public string? iparams { get; set; }

        public string? @params { get; set; }

        public override readonly string ToString()
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(name))
                sb.Append($"\"{name}\" ");

            var info = "<";
            if (!string.IsNullOrWhiteSpace(tech))
                info += $"{tech}:";

            if (!string.IsNullOrWhiteSpace(user))
                info += $"{user}@";

            if (!string.IsNullOrWhiteSpace(domain))
            {
                info += domain;

                if (port > 0)
                    info += $":{port}";
            }

            if (!string.IsNullOrWhiteSpace(iparams))
                info += $";{iparams}";

            info += ">";
            sb.Append(info);

            if (!string.IsNullOrWhiteSpace(@params))
                sb.Append($";{@params}");

            return sb.ToString();
        }

        public static implicit operator string?(CallerId? user) 
        {
            var text = user?.ToString();
            if (!string.IsNullOrWhiteSpace(text))
                return text;

            return null;
        }
    }
}
