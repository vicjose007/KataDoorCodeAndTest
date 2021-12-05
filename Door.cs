using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoorCode
{
    public class Door
    {
        public bool Opened, Unlocked;

        Door obj;

        public Door(bool Opened, bool Unlocked)
        {
            this.Opened = Opened;
            this.Unlocked = Unlocked;
        }
        public bool isOpen
        {
            get
            {
                return Opened;
            }
        }
        public bool isClosed
        {
            get
            {
                return !Opened;
            }
        }
        public bool isLocked
        {
            get
            {
                return !Unlocked;
            }
        }
        public bool isUnlocked
        {
            get
            {
                return Unlocked;
            }
        }
        public bool Open()
        {
            obj = new Door(isOpen, isUnlocked);

            return true;
        }

        public bool Close()
        {
            obj = new Door(isClosed, isUnlocked);

            return true;
        }
        public bool Lock(string key)
        {
            if (key == "Lock")
            {
                obj = new Door(isClosed, isLocked);

                return true;
            }
            else
            {
                obj = new Door(isOpen, isLocked);
                return false;

            }
        }

        public bool Unlock(string key)
        {
            if (key == "Unlock")
            {
                obj = new Door(isOpen, isUnlocked);

                return true;
            }
            else
            {
                obj = new Door(isClosed, isUnlocked);
                return false;
            }
        }

        public bool OpenAndUnlocked(string key)
        {
            if (obj.Open() && obj.Unlock(key) && key == "Unlock")
            {
                Console.WriteLine("Is Opened and Unlocked");
                obj = new Door(isOpen, isUnlocked);

                return true;
            }
            else
            {
                Console.WriteLine("Couldn't Open and Unlock");
                return false;
            }
        }

        public bool OpenAndLocked(string key)
        {
            if (obj.Open() && obj.Lock(key) && key == "Lock")
            {
                Console.WriteLine("Is Opened and Locked");
                obj = new Door(isOpen, isLocked);

                return true;
            }
            else
            {
                Console.WriteLine("Couldn't Open and Lock");
                return false;
            }
        }

        public bool ClosedAndUnlocked(string key)
        {
            if (obj.Open() && obj.Unlock(key) && key == "Unlock")
            {
                Console.WriteLine("Is Closed and Unlocked");
                obj = new Door(isOpen, isUnlocked);

                return true;
            }
            else
            {
                Console.WriteLine("Couldn't Close and Unlock");
                return false;
            }
        }

        public bool ClosedAndLocked(string key)
        {
            if (obj.Open() && obj.Lock(key) && key == "Lock")
            {
                Console.WriteLine("Is Closed and Locked");
                obj = new Door(isOpen, isLocked);

                return true;
            }
            else
            {
                Console.WriteLine("Couldn't Close and lock");
                return false;
            }
        }
    }
}
