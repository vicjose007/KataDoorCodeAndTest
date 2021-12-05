using DoorCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTest
{
    [TestClass]
    public class DoorUnitTests
    {
        [Fact]
        public void Validate_OpenDoor()
        {
            Door obj = new Door(true,true);

            bool result = obj.Open();

            Assert.IsTrue(result);
        }
        [Fact]
        public void Validate_CloseDoor()
        {
            Door obj = new Door(true, true);

            bool result = obj.Close();

            Assert.IsTrue(result);
        }
        [Fact]
        public void Validate_Lock()
        {
            Door obj = new Door(true, true);

            string key = "Lock";

            bool result = obj.Lock(key);

            Assert.IsTrue(result);
        }
        [Fact]
        public void Validate_Unlock()
        {
            Door obj = new Door(true, true);

            string key = "Unlock";

            bool result = obj.Unlock(key);

            Assert.IsTrue(result);
        }
        [Fact]
        public void Validate_Open_And_Unlocked_Door()
        {
            Door obj = new Door(true, true);

            string key = "Unlock";

            obj.Unlock(key);

            bool result = obj.OpenAndUnlocked(key);

            Assert.IsTrue(result);
        }
        [Fact]
        public void Validate_Open_And_Locked_Door()
        {
            Door obj = new Door(true, true);

            string key = "Lock";

            obj.Lock(key);

            bool result = obj.OpenAndLocked(key);

            Assert.IsTrue(result);
        }
        [Fact]
        public void Validate_Closed_And_Unlocked_Door()
        {
            Door obj = new Door(true, true);

            string key = "Unlock";

            obj.Unlock(key);

            bool result = obj.ClosedAndUnlocked(key);

            Assert.IsTrue(result);
        }
        [Fact]
        public void Validate_Closed_And_Locked_Door()
        {
            Door obj = new Door(true, true);

            string key = "Lock";

            obj.Lock(key);

            bool result = obj.ClosedAndLocked(key);

            Assert.IsTrue(result);
        }


    }

}