using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    /**
     * kaarten en vakjes kunnen acties hebben, deze actie worden dan uitgevoerd als de speler een kaart pakt of op een vakje komt.
     */
    public abstract class Actie
    {
        public Actie()
        {

        }

        public abstract void VoerUit();
    }


}
