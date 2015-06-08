using NUnit.Framework;
using TripServiceKata.Exception;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    [TestFixture]
    public class TripServiceShould
    {
        private static User.User loginUser;

        private User.User _guest = null;
        private User.User _someloginuser = new User.User();
        private User.User _anotherloginuser = new User.User();
        private Trip.Trip _paris = new Trip.Trip();

        public class TripServiceExt : TripService
        {
            protected override User.User GetLoggedUser()
            {
                return loginUser;
            }

            protected override System.Collections.Generic.List<Trip.Trip> FindTripsByUser(User.User user)
            {
                return user.Trips();
            }
        }

        [Test]
        public void Throw_exception_if_not_logged()
        {
            var trip = new TripServiceExt();

            loginUser = _guest;
            Assert.Catch(typeof(UserNotLoggedInException), () => trip.GetTripsByUser(loginUser));
        }

        [Test]
        public void Returns_no_trip_if_user_has_no_friend()
        {
            var trip = new TripServiceExt();
            loginUser = _someloginuser;

            var trips = trip.GetTripsByUser(new User.User());

            Assert.AreEqual(0, trips.Count);
        }

        [Test]
        public void Returns_trips_if_user_has_friend()
        {
            loginUser = _someloginuser;

            var trip = new TripServiceExt();
            var friend = _anotherloginuser;

            friend.AddTrip(_paris);
            friend.AddFriend(loginUser);

            var trips = trip.GetTripsByUser(friend);

            Assert.AreEqual(1, trips.Count);
        }

    }
}
