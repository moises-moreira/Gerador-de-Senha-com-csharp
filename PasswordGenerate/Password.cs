using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerate
{
    internal class Password
    {
        private string caractersAllow = "ABCDEFGHIJKLMNOPQRSTUVXIZÇ" +
            "ABCDEFGHIJKLMNOPQRSTUVXIZÇ".ToLower() +
            "0123456789" + @"/*-+!@#$%¨&*()_\[]{}";
        private string newPasswordGenerated = "";
        private int index;

        public string GeneratePassword()
        {
            newPasswordGenerated = "";
            Random random = new Random();
            int caractersLenght = 8;
            for (int i = 0; i < caractersLenght; i++)
            {
                index = random.Next(0, caractersAllow.Length -1);
                newPasswordGenerated += caractersAllow[index];
            }
            return newPasswordGenerated;
        }
    }
}
