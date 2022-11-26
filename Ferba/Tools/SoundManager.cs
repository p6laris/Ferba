using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Ferba.Tools
{
    internal class SoundManager : IDisposable
    {
        public bool IsPlaying { get; private set; }
        SoundPlayer _player;
        bool _isLooping;
        private bool disposedValue;

        public SoundManager(UnmanagedMemoryStream Stream, bool IsLooping = false)
        {
            _player = new(Stream);
            IsLooping = _isLooping;
        }

        /// <summary>
        /// Play's the sound.
        /// </summary>
        public void PlaySound()
        {
            if (_isLooping)
                _player.PlayLooping();
            else
                _player.Play();

            IsPlaying = true;
        }

        /// <summary>
        /// Stop's the sound.
        /// </summary>
        public void StopSound()
        {
            if (IsPlaying)
                _player.Stop();

            IsPlaying = false;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _player.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        { 
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
