using UnityEngine;
using UnityEngine.FrameRecorder;

namespace UTJ.FrameCapturer.Recorders
{
    public abstract class BaseFCRecorderSettings : RecorderSettings
    {
        public override bool isValid
        {
            get
            {
                return base.isValid && !string.IsNullOrEmpty(m_DestinationPath.GetFullPath()) && !string.IsNullOrEmpty(m_BaseFileName.pattern);
            }
        }

        public override bool isPlatformSupported
        {
            get
            {
                return UnityEngine.Application.platform == RuntimePlatform.WindowsEditor ||
                       UnityEngine.Application.platform == RuntimePlatform.WindowsPlayer ||
                       UnityEngine.Application.platform == RuntimePlatform.OSXEditor ||
                       UnityEngine.Application.platform == RuntimePlatform.OSXPlayer ||
                       UnityEngine.Application.platform == RuntimePlatform.LinuxEditor ||
                       UnityEngine.Application.platform == RuntimePlatform.LinuxPlayer;
            }
        }
    }
}
