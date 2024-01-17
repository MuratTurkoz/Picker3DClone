using System;
using Commands.Level;
using Data.UnityObjects;
using Data.ValueObjects;
using UnityEngine;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {
        #region Self Variables

        #region Private Variables

        [SerializeField] private Transform _levelHolder;
        [SerializeField] private byte _totalLevelCount;

        #endregion

        private OnLevelLoaderCommand _levelLoaderCommand;
        private OnLevelDestroyCommand _levelDestroyCommand;

        private byte _currentLevel;
        private LevelData _levelData;

        #endregion

        private void Awake()
        {
            _levelData = GetLevelData();
            _currentLevel = GetActiveLevel();
        }

        private void Init()
        {
            _levelLoaderCommand = new OnLevelLoaderCommand(_levelHolder);
            _levelDestroyCommand = new OnLevelDestroyCommand(_levelHolder);
        }


        private LevelData GetLevelData()
        {
            return Resources.Load<CD_Level>("Data/CD_Level").Levels[_currentLevel];
        }
        
        private byte GetActiveLevel()
        {
            return new byte();
        }
    }
}