## UNITY 공부

목적 : Unity의 Gameobject 생성 및 삭제, rigidbody를 통한 물리적 기능, 충돌 감지, prefab 활용한 생성, 애니메이션 적용

#### Dodge
목표 : 회전하는 바닥위의 bulletspawner에서 생성된 bullet을 오랫동안 피하기

Bullet.cs
```
  가속, 3초후 없어짐 / 충돌시 player면 playerController.Die()
```

BulletSpawner.cs
```
  랜덤한 주기로 bullet을 생성시키고, bullet의 방향을 player 위치로 설정.
```

PlayerController.cs
```
  입력을 받아 player를 상하좌우로 이동시키고, Die() -> player 비활성화 및 gameManager.EndGame()
```
  
Rotator.cs
```
  바닥을 특정속도로 회전시킴
```

GameManager.cs
```
  게임이 끝날 때 생존시간을 측정하고, R 키가 눌리면 게임을 다시 시작함. EndGame() -> Best score 처리와 UI 처리
```

#### Unirun
목표 : 많은 발판을 밟아 살아남기

BackgroundLoop.cs
```
  배경을 이동시키는 중 왼쪽 끝에 도달하면 위치를 재배치한다.
```

GameManager.cs
```
   게임 오버일 때 게임을 재시작, AddScore(newScore) -> 스코어 계산, OnPlayerDead() -> 게임 오버 및 UI 활성화
```

Platform.cs
```
  OnEnable() -> 발판을 리셋한다. 충돌시 플레이어 이고 밟힌적이 없다면 점수 추가
```

PlatformSpawner.cs
```
  발판 생성, 주기적으로 발판 리스트를 돌며 랜덤위치에 발판 생성
```

PlayerController.cs
```
  입력을 통해 점프하고 2번까지 점프가능. 버튼을 땔때 속력이 절반이 된다. 점프소리재생
  Die() -> 사망처리, 사망소리 재생
  충돌시 바닥이면 점프횟수 초기화 및 바닥에 있음, 장애물이면 Die()
  충돌이 아니면 바닥에 없음.
```

ScrollingObject.cs
```
  게임 오브젝트를 왼쪽으로 이동시킨다.
```

애니메이션을 만들고 상태에 따라 어떤 애니메이션을 쓸지 유니티에서 설정
