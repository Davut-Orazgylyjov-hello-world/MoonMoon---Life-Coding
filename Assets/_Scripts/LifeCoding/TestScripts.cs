using UnityEngine;
using Zenject;
using UniRx;
using Cysharp.Threading.Tasks;

namespace LifeCoding
{
//TODO В проекте уже установлены UniTask/UniRx/Zenject. Ваша цель выполнить задачу, но с использованием этих библиотек

    public interface IHealthService
    {
        IReadOnlyReactiveProperty<int> Health { get; }
        void TakeDamage(int amount);
    }

    public class Player : MonoBehaviour
    {
        // TODO: Внедрить IHealthService
        // TODO: Подписаться на Health и выводить значение в Debug.Log
        // TODO: Наносить урон игроку каждые 2 секунды через UniTask
    }

    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // TODO: Привязать IHealthService к реализации
        }
    }
}