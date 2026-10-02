using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04TV_15
{
    class Tv
    {

        #region attributi

        private bool onOff;
        private int channel;
        private int volume;
        
        #endregion

        #region costruttori

        public Tv()
        {
            onOff = false;
            channel = 1;
            volume = 10;
        }

        public Tv(int channel)
        {
            onOff = false;
            this.channel = channel;
            volume = 0;
        }

        public Tv(int channel, int volume)
        {
            onOff = false;
            this.channel = channel;
            this.volume = volume;
        }

        public Tv(int channel, int volume, bool onOff)
        {
            this.onOff = onOff;
            this.channel = channel;
            this.volume = volume;
        }

        #endregion

        #region Set&Get

        public void SetonOff(bool onOff)
        {
            this.onOff = onOff;
        }
        public void Setchannel(int channel)
        {
            this.channel = channel;
        }
        public void Setvolume(int volume)
        {
            this.volume = volume;
        }
        public bool GetonOff()
        {
            return onOff;
        }
        public int Getchannel()
        {
            return channel;
        }
        public int Getvolume()
        {
            return volume;
        }
        public string Getchannel(string x)
        {
            return x + Convert.ToString(channel);
        }
        public string Getvolume(string x)
        {
            return x + Convert.ToString(volume);
        }

        #endregion

        #region Metodi
        public bool OnOffTv()
        {
            SetonOff(!GetonOff());
            return GetonOff();
        }
        public void NextChannel()
        {
            Setchannel(Getchannel() + 1);
            if (Getchannel() > 500) Setchannel(500);
        }
        public void PreviousChannel()
        {
            if (channel > 1) Setchannel(Getchannel() - 1);
        }
        public void MoreVolume()
        {
            Setvolume(Getvolume() + 1);
            if (Getvolume() > 100) Setvolume(100);
        }
        public void LessVolume()
        {
            if (Getvolume() > 0) Setvolume(Getvolume() - 1);
        }
        #endregion

    }
}
