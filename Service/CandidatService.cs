using System;
using System.Collections.Generic;
using PFA.Models;

namespace PFA.Service
{
    public class CandidatService: ICandidatService
    {

        private List<Candidat> _candidats;

        public CandidatService()
        {
            _candidats = new List<Candidat>();
        }

        public List<Candidat> GetCandidats()
        {
            return _candidats;
        }

        public Candidat AddCandidat(Candidat candidat)
        {
            _candidats.Add(candidat);
            return candidat;
        }

        public Candidat UpdateCandidat(int id, Candidat candidat)
        {
            for (var index = _candidats.Count - 1; index >= 0; index--)
            {
                if (_candidats[index].ID_Candidat == id)
                {
                    _candidats[index] = candidat;
                }
            }
            return candidat;
        }

        public int DeleteCandidat(int id)
        {
            for (var index = _candidats.Count - 1; index >= 0; index--)
            {
                if (_candidats[index].ID_Candidat == id)
                {
                    _candidats.RemoveAt(index);
                }
            }

            return id;
        }


    }
}
