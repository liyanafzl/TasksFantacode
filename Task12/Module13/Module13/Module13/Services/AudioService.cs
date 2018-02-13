﻿using Plugin.AudioRecorder;
using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module13.Services
{
    public class AudioService : IAudioRecordService
    {
        public  async Task<string> RecordAudio()
        {
            string audioFile = null;
            var _recorder = new AudioRecorderService
            {
                StopRecordingAfterTimeout = true,
                TotalAudioTimeout = TimeSpan.FromSeconds(10),
                AudioSilenceTimeout = TimeSpan.FromSeconds(2)
            };
            try
            {
                if (!_recorder.IsRecording)
                {
                    var recordTask = await _recorder.StartRecording();
                    audioFile = await recordTask;
                }
                return audioFile;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public  async Task PlayAudio(string speech)
        {
            try
            {
                await CrossTextToSpeech.Current.Speak(speech);//, null, 0.8F, 0.8F, 1, null
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
