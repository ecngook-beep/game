namespace Game.Application.Interfaces
{
    public interface ISaveService
    {
        void SaveInt(string key, int value);
        int LoadInt(string key, int defaultValue = 0);
        void SaveFloat(string key, float value);
        float LoadFloat(string key, float defaultValue = 0f);
    }
}
