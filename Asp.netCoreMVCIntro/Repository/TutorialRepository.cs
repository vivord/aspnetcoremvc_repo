using Asp.netCoreMVCIntro.Models;

namespace Asp.netCoreMVCIntro.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly List<Tutorial> _tutorials;
        public TutorialRepository()
        {
            _tutorials = new List<Tutorial>()
            {
                new Tutorial{Id =1, Name = "C#", Description = "C# Tutorial"},
                new Tutorial{Id =2, Name = "Asp.net core", Description = "Asp.net core Tutorial"},
            };
        }
        public Tutorial Add(Tutorial tutorial)
        {
            throw new NotImplementedException();
        }

        public Tutorial Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tutorial> GetAllTutorial()
        {
            return _tutorials;
        }

        public Tutorial GetTutorial(int Id)
        {
            throw new NotImplementedException();
        }

        public Tutorial Update(Tutorial tutorial)
        {
            throw new NotImplementedException();
        }
    }
}
