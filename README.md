### Chapter3PersonalAssignment

Chapter 3-1 Unity 게임개발 입문 개인과제  
제출자 유니티 2기 이규성입니다.

#### 과제 개요

1. Unity 를 이용해 게더를 모방해 만드는 과제입니다.
2. 타일맵을 이용해 배경을 꾸밉니다.
3. 기본 UI 들을 활용해 적용하는 연습이 포함됩니다.

필수 요구사항  
1. 캐릭터 만들기
2. 캐릭터 이동
3. 방 만들기
4. 카메라 따라가기

구현에 성공한 선택 요구사항
1. 캐릭터 애니메이션 추가
2. 현재 시간 표시


#### 작동 예시
![2023-11-29 11-11-32 (1)](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/cf6724cb-948b-4ef0-8de5-8af0c8ca513a)  
캐릭터의 애니메이션, 이동, 마우스 포인터에 따라 방향 전환, 현재 시간

![2023-11-29 11-16-55 (1)](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/9473fcff-40de-4fc9-a7d4-25427075be75)  
타일맵을 활용한 맵 제작, 캐릭터와 맵의 벽 간의 충돌 구현

### 2023/12/13 Chapter 3-2 Unity 게임개발 숙련 개인과제  
메인 화면 구성  
아이디  
레벨  
골드  
Status 버튼  - 2. Status 보기  
Inventory 버튼  - 3. Inventory 보기
![1](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/17d49c57-cc26-452d-b650-ef8b9e779c31)  
Status 보기  
Status 버튼, Inventory 버튼 - 사라지기  
우측에 캐릭터 정보 표현  
뒤로가기 버튼을 누르면 1번 화면으로 이동  
![2](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/38f8b960-5d8b-4f57-ab64-75a806f8e962)  
Inventory 보기  
Status 버튼, Inventory 버튼 - 사라지기  
우측에 인벤토리 표시  
아이템을 클릭하면 장착관리  
아이템 장착 중 - X  : 장착 확인 팝업  
아이템 장착 중 - O  : 장착해제 확인 팝업  
장착중인 아이템은 표시  
<img width="190" alt="3" src="https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/6e2e8dd6-77bf-4371-9b78-a5c2604a04da">  
이번에는 필수 요구 사항만을 구현하였습니다.

#### 작동 예시  
메인 뷰  
![4](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/d6629559-ee1d-4eb0-a311-3c6edbb83957)  

스테이터스 창  
![5](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/a1035168-d2c3-4ad1-821e-b01a6c97a0d2)

인벤토리 창  
![6](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/e50afeeb-386b-4513-b406-2ea1453b28d2)

아이템 장착  
![7](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/224060db-b225-4d51-bdf9-0f32a52538ae)

아이템 장착 시 스탯에 적용
![8](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/4e714459-1202-428c-b42b-c6966bd0b352)

#### 시도하였으나 실패한 기능들. . .
아이템의 중복착용  
![9](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/1634b3a4-1c49-4a5b-8937-6460952f958d)  
무기를 하나 장착하면 나머지는 장착이 불가능하게 구현하고 싶었으나 장착 구현 설계에서부터 조금 잘못된 것 같다. . .

아이템의 플립 문제
![10](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/adb70d94-196f-4f8f-a4bc-53d0ca61ccd7)
![11](https://github.com/ssungyeee/Chapter3PersonalAssignment/assets/149459020/4a504147-d751-4d73-9ccc-005409afd447)
Sprite Renderer를 weapon1번 오브젝트와 연결시켜서 구현을 했다 보니 다른 아이템 착용을 고려하지 못한 설계 실수가 있었다. . . 컴포넌트, 배열 등 다양한 방법을 시도해 보았지만 실패했다. . .

#### 231214 오류 수정  
아이템의 플립 문제를 수정하였습니다.  
https://velog.io/@leedlrbtjd/37.-Unity-%EA%B2%8C%EC%9E%84%EA%B0%9C%EB%B0%9C-%EC%88%99%EB%A0%A8-1%EC%A3%BC%EC%B0%A85












