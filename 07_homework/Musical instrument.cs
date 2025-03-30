using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_homework
{
    internal abstract class Musical_instrument
    {
        private string name = "NoName",sound_ = "NoSound", description = "NoDesc",history_ = "NoHistory";
        protected virtual string Name { get=>name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Error {value}");
                }
                name = value;
            }
        }

        protected virtual string Sounds
        {
            get => sound_;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Error {value}");
                }
                sound_ = value;
            }
        }

        protected virtual string Description
        {
            get => description;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Error {value}");
                }
                description = value;
            }
        }        
        
        protected virtual string History_
        {
            get => history_;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Error {value}");
                }
                history_ = value;
            }
        }

        public Musical_instrument(string name,string sound,string description,string history)
        {
            Name = name;
            Sounds = sound;
            Description = description;
            History_ = history;
        }
        public abstract void Sound_();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();
    }
}
