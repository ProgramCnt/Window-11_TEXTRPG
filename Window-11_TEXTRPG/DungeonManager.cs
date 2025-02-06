using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_11_TEXTRPG
{
    public class DungeonManager : IScene
    {
        //빈 몬스터 배열 추가
        List<Monster> monsters = new List<Monster>();

        public void Enter()
        {
            //플레이어 입력
        }

        //몬스터 생성
        public void SetMonsters() 
        {
        
        }

        //몬스터 타겟 지정
        public void TargetMonster(int index)
        {

        }

        //몬스터 공격
        public void MonsterAttck(Monster monster)
        {

        }

        //전투 패배
        public void Lose()
        {

        }

        //전투 승리
        public void Victory()
        {

        } 
    }
}
