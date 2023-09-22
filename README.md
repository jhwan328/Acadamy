# 유니티 A06 이정환 
# 과제2 필수 요구사항 모두 구현, 선택 요구 사항  2. 상점 기능 는 구현했으나 1. 아이템 장착 팝업 업그레이드 에서 오류가 있음. 마지막에 발견된 오류라 시간이 없어 수정 못했습니다.

#Stat UI
  1. OpeningSceneManager에서 생성될 때 캐릭터를 받는다.
  2. 캐릭터의 정보를 읽어와  StatusSlot 생성
  3. 우측 상단의 CloseButton을 눌렀을 때 Destroy가 아니라 비활성화
  4. (미구현) 캐릭터에 이벤트 시스템을 만들어 아이템 장착, 탈착 시 스탯 변화

#Inventoty UI
  1. OpeningSceneManager에서 생성될 때 캐릭터, ItemStatManager를 받는다.
  2. 캐릭터의 인벤토리를 읽어온다. 이때 캐릭터는 정수형 변수인 ItemNumber만 가지고 있다.
  3. ItemStatManager에 ItemNumber를 입력하여 Item 정보를 받아온다.
  4. 링크된 Prefab, Slot_Inventory 를 생성하면서 Item을 Slot에 준다.
  5. 우측 상단의 CloseButton을 눌렀을 때 Destroy가 아니라 비활성화, 활성화 시 Slot의 데이터들을 업데이트.
  6. CloseButton을 눌러 나갔다 들어왔을 때 아이템이 장착되어 있으면 'E' 아이콘 활성화, 아니면 비활성화
  7. (미구현) Slot에서 아이템을 장착했을 때 바로 장착했다는 표시로 'E'아이콘이 뜨게 한다.
  8. (오류) 아이템을 장착하고 비활성화, 활성화 했을 때 어디선가 Null 값이라고 에러가 나온다. 진행에는 지장없음.

#Shop UI
  1. OpeningSceneManager에서 생성될 때 ItemStatManager를 받는다.
  2. ItemNumber가 저장된 정수형 배열 ShopInventory를 가지고 있고 이를 통해 ItemStatManager에서 Item을 받아와 ShopItemBar를 생성한다.
  3. ShopItemBar는 화면에 최대 3개만 띄워주며 그보다 많을 경우 다음 Page로 넘어간다. 이차원 리스트를 통해 구현
  4.우측 상단의 CloseButton을 눌렀을 때 Destroy가 아니라 비활성화
  5. (미구현)  ShopInventory에 캐릭터가 보유하지 않은 아이템들만 존재하게 한다. 지금은 하드코딩으로 직접 넣어줌.

#Player UI 
  1. OpeningSceneManager에서 생성될 때 캐릭터를 받는다.
  2. 캐릭터 정보에 따라 이름, 칭호, 경험치, 레벨, 현재 소지한 골드를 화면에 띄운다.
  3. 상점에서 골드를 사용한 경우 골드를 바꾼다. 이는 델리게이트와 구독을 통해 구현

#아쉬운 점
  1. 특강 때 PopUP을 델리게이트를 통해 구현하는 걸 보고 따라하려고 했지만 버튼을 눌렀을 때 델리게이트를 어떻게 적용해야 하는지 몰라 기존의 버튼을 눌렀을 때 링크된 오브젝트를 활성화, 비활성화 하는 방법으로 돌아왔다.
  2. ScriptableObject의 원본, 복사본 개념을 모른 체로 구현하여 플레이어와 상점이 같은 물건을 지니게 할 수 없었다.
  3. 2와 비슷한 이유로 상점에서 여러개 구매해서 들고다니는 물약을 구현포기. 플레이어가 30개 가지면 상점도 30개 가지고 있었다.
  4. 데이터 저장에 json이나 PlayerPref을 사용하고 싶었지만 json은 새롭게 배워야 하는 게 많아 보였고, PlayerPref는 눈으로 데이터를 직접 볼 수 없어 일단 플레이어 정보를 지닌 GameObject를 만들어서 하다보니 나중에는 오류가 날 것 같아 시도해보지 못했다.
  5. 항상 Canvas를 Overlay만 사용하다가 WorldScale을 사용했는데 이번에는 WorldScale만 사용하는 바람에 애초에 원했던 캔버스 Render Mode의 차이들과 적절한 쓰임새를 알지 못했다.
  6. 5와 비슷한 이유로 WorldScale만 사용하다가 16:9에서만 정상적으로 보이고 나머지에는 이상하게 보였다.
  7. ItemSprite를 인벤토리에 맞춰서 그렸는데 똑같은 Sprite를 다른 크기로 사용하다보니 화질이 이상했다. Canvas에서 Image나 Sprite의 크기를 잡을 때 눈으로 보면서 조절하다보니 내가 필요한 게 몇 가로세로 몇 픽셀인 Sprite인지 알지 못했다.
  8. Text, Sprite와 같은 UI 요소들을 이렇게 많이 사용하는 건 처음이었고 보이지 않는 필요이상으로 큰 Canvas가 Button을 가려 Button이 작동되지 않아 시간을 들어 모든 Prefab의 UI들을 수정해야 했다. 
