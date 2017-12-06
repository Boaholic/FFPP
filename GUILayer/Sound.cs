using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Threading;

namespace GUILayer
{
    public static class Sound
    {
        static public readonly SoundPlayer menuSoundPlayer = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.menuSound);
        //static public readonly SoundPlayer drumSoundPlayer = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.drumSound);
        static public readonly SoundPlayer vicotrySoundPlayer = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.victorySound);

        static public readonly SoundPlayer[] shotSoundPlayers = new SoundPlayer[3];
        static public readonly SoundPlayer[] splashSoundPlayers = new SoundPlayer[3];
        static public readonly SoundPlayer[] hitSoundPlayers = new SoundPlayer[3];

        static Sound()
        {
            shotSoundPlayers[0] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.shot0Sound);
            shotSoundPlayers[1] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.shot1Sound);
            shotSoundPlayers[2] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.shot2Sound);

            splashSoundPlayers[0] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.splash0Sound);
            splashSoundPlayers[1] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.splash1Sound);
            splashSoundPlayers[2] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.splash2Sound);

            hitSoundPlayers[0] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.hit0Sound);
            hitSoundPlayers[1] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.hit1Sound);
            hitSoundPlayers[2] = new SoundPlayer(FloatyFloatyPewPew.Properties.Resources.hit2Sound);
        }

        static public void PlayShot()
        {
            Sound.shotSoundPlayers[GlobalState.RandomNumber(shotSoundPlayers.Length)].Play();
        }

        static public void PlaySplash()
        {
            Sound.splashSoundPlayers[GlobalState.RandomNumber(splashSoundPlayers.Length)].Play();
        }

        static public void PlayHit()
        {
            Sound.hitSoundPlayers[GlobalState.RandomNumber(hitSoundPlayers.Length)].Play();
        }

    }
}
