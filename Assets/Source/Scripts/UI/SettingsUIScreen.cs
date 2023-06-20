using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsUIScreen : UIScreen
{
    [Header("Buttons")]
    [SerializeField] private Button _audioToggle;
    [SerializeField] private Button _vibrationToggle;
    
    [Header("Audio Group")] 
    [SerializeField] private AudioMixerGroup _mixerGroup;
    
    [Header("Icons")] 
    [SerializeField] private Image _audioCross;
    [SerializeField] private Image _vibrationCross;

    public override UIScreenType GetUIType()
    {
        return UIScreenType.SETTINGS;
    }

    public override void Init(IGameDataContainer gameDataContainer, GameCanvas gameCanvas)
    {
        base.Init(gameDataContainer, gameCanvas);
        
        _audioToggle.onClick.AddListener(ToggleAudio);
        _vibrationToggle.onClick.AddListener(ToggleVibration);

        UpdateIcons();
    }

    private void ToggleVibration()
    {
        /*HapticController.hapticsEnabled = !HapticController.hapticsEnabled;

        _vibrationCross.gameObject.SetActive(!HapticController.hapticsEnabled);*/
    }

    private void ToggleAudio()
    {
        _mixerGroup.audioMixer.GetFloat("Volume", out float volume);
        bool wasMuted = volume < 0;
        
        _mixerGroup.audioMixer.SetFloat("Volume", wasMuted ? 0 : -80f);

        _audioCross.gameObject.SetActive(!wasMuted);
    }
    
    private void UpdateIcons()
    {
        _mixerGroup.audioMixer.GetFloat("Volume", out float volume);
        bool isMuted = volume < 0;
        _audioCross.gameObject.SetActive(isMuted);
        
        //_vibrationCross.gameObject.SetActive(!HapticController.hapticsEnabled);
    }
}