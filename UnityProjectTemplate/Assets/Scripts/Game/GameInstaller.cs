using UnityEngine;
using Zenject;

namespace Game
{
    public class GameInstaller : MonoInstaller<GameInstaller>
    {
        public override void InstallBindings()
        {
            DefinitionsData defData = new DefinitionsData();
            DefinitionsLoader.LoadDefinitions(defData);

            Container.Bind<DefinitionsData>().FromInstance(defData).AsSingle();

            Container.Bind<GameStateManager>().AsSingle().NonLazy();
            Container.Bind<UserData>().AsSingle().NonLazy();
        }
    }
}