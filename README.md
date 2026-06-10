# Delta - 야스카와 로봇 용접 위치 보정 시스템

개발자: 양국진 | 인수인계일: 2026-06-10

## 프로젝트 구성

| 폴더 | 설명 |
|------|------|
| `AIL/` | Zebra Aurora Imaging Library 기반 카메라 영상 획득 및 패턴 매칭 예제 |
| `ETHERCAT/` | 커미조아 COMI-LX550 EtherCAT 보드 제어 예제 |
| `ROBOT_CORRECT_VER2/` | 야스카와 YRC1000 로봇 용접 위치 보정 메인 프로그램 |
| `Readme/` | 인수인계 체크리스트 및 개발자 답변 문서 |

## 개발 환경

| 항목 | 버전 |
|------|------|
| .NET | 10.0 (ROBOT_CORRECT_VER2) / 4.8 (ETHERCAT) |
| Zebra AIL | 11.B.6 |
| Basler Pylon SDK | 25.11.0 |
| EmguCV | 4.12.0.5764 |
| 커미조아 ComiECAT SDK | COMI-IDE 1.11.23 |

## 하드웨어

- **로봇**: 야스카와 YRC1000
- **카메라**: Basler acA2440-20GC (2448 × 2048)
- **EtherCAT 보드**: 커미조아 COMI-LX550 + LS메카피온 IO슬레이브
- **IO 모듈**: FTECH 아두이노 모듈 (시리얼 115200 baud)

## 대용량 파일 (Git 미포함)

아래 파일은 용량 또는 저작권 문제로 GitHub에 포함되지 않습니다.

| 파일 | 크기 | 설명 | 다운로드 |
|------|------|------|----------|
| `ail11b602win.zip` | 8.1 GB | Zebra Aurora Imaging Library v11.B.6 설치파일 | [Google Drive (공유드라이브-유틸리티)](https://drive.google.com/drive/u/1/folders/0ALFmUCoiCRmSUk9PVA) |
| `YRC1000_Ethernet fuction.pdf` | 10 MB | 야스카와 YRC1000 이더넷 서버 기능 매뉴얼 | - |
| `ethercat_master_manual_api_reference_20210520.pdf` | 8.6 MB | 커미조아 EtherCAT API 레퍼런스 | - |
| `ComiIDE v1.11.22.0.7z` | 4.4 MB | 커미조아 IDE 설치파일 | - |

> ⚠️ **AIL 라이선스 주의**: `ail11b602win.zip`은 개발자 명의 차용 라이선스로 개발됨.
> 개발자가 업체에 반납 예정이므로 **라이선스를 별도 구입해야 다른 PC에 설치 가능**.

## 인수인계 문서

`Readme/` 폴더 참조:
- `1. 인수인계_체크리스트_V2.txt` — 전체 인수인계 체크리스트 (개발자 답변 포함)
- `2. 버그_수정확인_체크리스트_V1.txt` — 버그 6건 AI 판단 및 개발자 의견
- `3. 2차분석_추가질문_체크리스트.txt` — 소스코드 심층 분석 추가 질문 및 답변
