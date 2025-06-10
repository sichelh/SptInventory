# Unity RPG Inventory System
![Image](https://github.com/user-attachments/assets/70ca6789-2102-42c2-8b2b-48788cb3c770)


Unity 기반의 간단한 RPG 인벤토리 시스템 프로젝트입니다.  
플레이어 정보, 상태창, 인벤토리 UI 및 아이템 장착 기능을 포함하고 있습니다.

## 📦 프로젝트 개요

이 프로젝트는 ScriptableObject를 활용하여 캐릭터 데이터와 아이템 데이터를 관리하고,  
UIManager를 통해 메인 메뉴, 상태창, 인벤토리 UI를 제어합니다.  
플레이어는 아이템을 장착/해제하며 능력치를 실시간으로 확인할 수 있습니다.

## 🔧 주요 기능

- **플레이어 데이터 관리**: `CharacterData` ScriptableObject로 초기 데이터 설정  
- **아이템 데이터 관리**: `ItemDataList` ScriptableObject를 통해 아이템 목록 관리
- **메인 메뉴 UI**: 플레이어 기본 정보 및 다른 UI 이동 버튼 제공  
- **상태창 UI**: 장착 아이템의 능력치가 반영된 플레이어 스탯 표시  
- **인벤토리 UI 시스템**: 보유한 아이템 표시 및 장착 상태 반영  
- **장착 시스템**: 같은 타입의 아이템은 1개만 장착 가능하며, 토글 방식으로 작동  

## 🧱 클래스 구성

### GameManager
- `CharacterData`, `ItemDataList`를 받아 초기화
- 플레이어 데이터 및 인벤토리 구성

### UIManager
- UI 컨트롤의 중심 관리자
- MainMenu, Status, Inventory UI 제어

### UIMainMenu
- 플레이어 기본 정보 표시
- 상태창/인벤토리 UI 이동 버튼

### UIStatus
- 장착된 아이템을 반영한 스탯 UI 출력

### UIInventory
- 보유 아이템 리스트 출력
- 아이템 장착 버튼 제공

### UISlot
- 개별 아이템 UI 슬롯
- 장착/해제 UI 동기화

### Character
- 플레이어 클래스
- 능력치, 인벤토리, 장착 리스트 관리

### Item
- 아이템 클래스
- 능력치 및 아이콘 정보 포함

## 📁 ScriptableObjects

### CharacterData
- 캐릭터 ID, 직업, 설명, 레벨, 능력치 포함

### ItemDataList
- 아이템 리스트 관리용 ScriptableObject
