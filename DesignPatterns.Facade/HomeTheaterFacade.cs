using DesignPatterns.Facade.HomeTheater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class HomeTheaterFacade
    {
        private DVDPlayer dvdPlayer;

        private Projector projector;

        private Screen screen;

        private PopcornPopper popcornPopper;

        public HomeTheaterFacade(DVDPlayer dvdPlayer, Projector projector, Screen screen, PopcornPopper popcornPopper)
        {
            this.dvdPlayer = dvdPlayer;
            this.projector = projector;
            this.screen = screen;
            this.popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movieName)
        {
            popcornPopper.On();
            popcornPopper.Pop();
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            dvdPlayer.On();
            dvdPlayer.Play(movieName);
            Console.WriteLine();
        }

        public void EndMovie()
        {
            popcornPopper.Off();
            screen.Up();
            projector.Off();
            dvdPlayer.Off();
        }
    }
}
