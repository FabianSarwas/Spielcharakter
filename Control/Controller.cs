using Spielcharakter.Model;
using Spielcharakter.View;

namespace Spielcharakter.Controllers
{
    public class CharakterController
    {
        private readonly CharakterView _view;

        public CharakterController(CharakterView view)
        {
            _view = view;
        }

        public void PerformAction(Basisklasse basisklasse)
        {
            var message = basisklasse.Action();
            _view.DisplayAction(message);
        }

        public void ShowCharakter(Basisklasse charakter)
        {
            _view.DisplayCharakter(charakter);
        }
    }
}
