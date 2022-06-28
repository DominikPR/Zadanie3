using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Model
    {
        public ObservableCollection<Film> ListaFilmów { get; } = new ObservableCollection<Film>() {
            new Film() {Tytuł="Iron Man", Reżyser="Jon Favreau", Studio="Marvel", Nośnik="Netflix", DataWydania=Convert.ToDateTime("2008.04.30")},
            new Film() {Tytuł="Kapitan Ameryka: Pierwsze starcie", Reżyser="Jon Favreau", Studio="Marvel", Nośnik="Netflix", DataWydania=Convert.ToDateTime("2011.08.05")},
            new Film() {Tytuł="Avengers", Reżyser="Joss Whedon", Studio="Marvel", Nośnik="Netflix", DataWydania=Convert.ToDateTime("2012.05.11")},
            new Film() {Tytuł="Mumia", Reżyser="Alex Kurtzman", Studio="Universal Pictures", Nośnik="HBO", DataWydania=Convert.ToDateTime("2017.06.09")},
            new Film() {Tytuł="Titanic", Reżyser="James Cameron", Studio="20th Century Fox", Nośnik="TV public", DataWydania=Convert.ToDateTime("1998.02.13")},
        };

        internal Film Nowy()
        {
            Film nowy = new Film();
            ListaFilmów.Add(nowy);
            return nowy;
        }

    }
}
