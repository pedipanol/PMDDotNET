﻿using musicDriverInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDDotNET.Driver
{
    public class PW
    {
        //PMD.ASM 7-53
        public const string ver = "4.8s";

        public MmlDatum[] md { get; internal set; }

        public int vers = 0x48;
        public string verc = "s";
        public string date = "Jan.22nd 2020";

        public int mdata_def = 16;
        public int voice_def = 8;
        public int effect_def = 4;
        public int key_def = 1;

        public string _myname = "PMD     COM";

        public int va = 0;//１の時ＶＡMSDOS用
        public int board2 = 0;//１の時ボード２/音美ちゃん有り
        public int adpcm = 0;//１の時ADPCM使用
        public int ademu = 0;//１の時ADPCM Emulate
        public int pcm = 0;//１の時PCM使用
        public int ppz = 0;//１の時PPZ8使用
        public int sync = 0;//１の時MIDISYNC使用
        public int vsync = 0;//１の時VSyncを止める
        public string resmes = "PMD ver." + ver;
        public int fmvd_init = 16;//９８は８８よりもＦＭ音源を小さく



        //PMD.ASM 114-116
        public int pmdvector = 0x60;//PMD用の割り込みベクトル
        public int ppsdrv = 0x64;//ppsdrvの割り込みベクトル
        public int ppz_vec = 0x7f;//ppz8の割り込みベクトル



        public byte open_work = 0;//label byte
        public int mmlbuf = 0;//Musicdataのaddress+1
        public int tondat = 0;//Voicedataのaddress
        public int efcdat = 0;//FM Effecdataのaddress
        public int fm1_port1 = 0;// FM音源 I/O port(表1)
        public int fm1_port2 = 0;//FM音源 I/O port(表2)
        public int fm2_port1 = 0;//FM音源 I/O port(裏1)
        public int fm2_port2 = 0;//FM音源 I/O port(裏2)
        public int fmint_ofs = 0;//FM割り込みフックアドレス offset
        public int fmint_seg = 0;//FM割り込みフックアドレス address
        public int efcint_ofs = 0;//効果音割り込みフックアドレス offset
        public int efcint_seg = 0;//効果音割り込みフックアドレス address
        public int prgdat_adr = 0;//曲データ中音色データ先頭番地
        public int radtbl = 0;//R part offset table 先頭番地
        public int rhyadr = 0;//R part 演奏中番地
        public byte rhythmmask = 0;//Rhythm音源のマスク x8c/10hのbitに対応
        public byte board = 0;//FM音源ボードあり／なしflag
        public byte key_check = 0;//ESC/GRPH key Check flag
        public byte fm_voldown = 0;//FM voldown 数値
        public byte ssg_voldown = 0;//PSG voldown 数値
        public byte pcm_voldown = 0;//PCM voldown 数値
        public byte rhythm_voldown = 0;//RHYTHM voldown 数値
        public byte prg_flg = 0;//曲データに音色が含まれているかflag
        public byte x68_flg = 0;//OPM flag
        public byte status = 0;// status1
        public byte status2 = 0;//status2
        public byte tempo_d = 0;//tempo(TIMER-B)
        public byte fadeout_speed = 0;//Fadeout速度
        public byte fadeout_volume = 0;//Fadeout音量
        public byte tempo_d_push = 0;//tempo(TIMER-B) / 保存用
        public byte syousetu_lng = 0;//小節の長さ
        public byte opncount = 0;//最短音符カウンタ
        public byte TimerAtime = 0;//TimerAカウンタ
        public byte effflag = 0;//PSG効果音発声on/off flag
        public byte psnoi = 0;//PSG noise周波数
        public byte psnoi_last = 0;//PSG noise周波数(最後に定義した数値)
        public byte fm_effec_num = 0;// 発声中のFM効果音番号
        public byte fm_effec_flag = 0;//FM効果音発声中flag(1)
        public byte disint = 0;// FM割り込み中に割り込みを禁止するかflag
        public byte pcmflag = 0;//PCM効果音発声中flag
        public int pcmstart = 0;//PCM音色のstart値
        public int pcmstop = 0;//PCM音色のstop値
        public byte pcm_effec_num = 0;//発声中のPCM効果音番号
        public int _pcmstart = 0;//PCM効果音のstart値
        public int _pcmstop = 0;//PCM効果音のstop値
        public int _voice_delta_n = 0;//PCM効果音のdelta_n値
        public byte _pcmpan = 0;//PCM効果音のpan
        public byte _pcm_volume = 0;//PCM効果音のvolume
        public byte rshot_dat = 0;//リズム音源 shot flag
        public byte[] rdat = new byte[6];//リズム音源 音量/パンデータ
        public byte rhyvol = 0b0011_1100;//リズムトータルレベル
        public int kshot_dat = 0;//ＳＳＧリズム shot flag
        public int ssgefcdat = 0;// efftbl  PSG Effecdataのaddress
        public int ssgefclen = 0;// efftblend-efftbl PSG Effecdataの長さ
        public byte play_flag = 0;// play flag
        public byte pause_flag = 0;// pause flag
        public byte fade_stop_flag = 0;//Fadeout後 MSTOPするかどうかのフラグ
        public byte kp_rhythm_flag = 0;//K/RpartでRhythm音源を鳴らすかflag
        public byte TimerBflag = 0;//TimerB割り込み中？フラグ
        public byte TimerAflag = 0;//TimerA割り込み中？フラグ
        public byte int60flag = 0;//INT60H割り込み中？フラグ
        public byte int60_result = 0;//INT60Hの実行ErrorFlag
        public byte pcm_gs_flag = 0;//ADPCM使用 許可フラグ(0で許可)
        public byte esc_sp_key = 0;// ESC +?? Key Code
        public byte grph_sp_key = 0;// GRPH+?? Key Code
        public byte rescut_cant = 0;// 常駐解除禁止フラグ
        public int slot_detune1 = 0;//FM3 Slot Detune値 slot1
        public int slot_detune2 = 0;// FM3 Slot Detune値 slot2
        public int slot_detune3 = 0;// FM3 Slot Detune値 slot3
        public int slot_detune4 = 0;// FM3 Slot Detune値 slot4
        public int wait_clock = 0;// FM ADDRESS-DATA間 Loop $の回数
        public int wait1_clock = 0;//loop $ １個の速度
        public byte ff_tempo = 0;//早送り時のTimerB値
        public byte pcm_access = 0;//PCMセット中は 1
        public byte TimerB_speed = 0;// TimerBの現在値(=ff_tempoならff中)
        public byte fadeout_flag = 0;// 内部からfoutを呼び出した時1
        public byte adpcm_wait = 0;//ADPCM定義の速度
        public byte revpan = 0;//PCM86逆走flag
        public byte pcm86_vol = 0;//PCM86の音量をSPBに合わせるか?
        public int syousetu = 0;//小節カウンタ
        public byte int5_flag = 0;//FM音源割り込み中？フラグ
        public byte port22h = 0;//OPN-PORT 22H に最後に出力した値(hlfo)
        public byte tempo_48 = 0;// 現在のテンポ(clock= 48 tの値)
        public byte tempo_48_push = 0;//現在のテンポ(同上/保存用)
        public byte rew_sp_key = 0;//GRPH+?? (rew) Key Code
        public byte intfook_flag = 0;//int_fookのflag B0:TB B1:TA
        public byte skip_flag = 0;//normal:0 前方SKIP中:1 後方SKIP中:2
        public byte _fm_voldown = 0;// FM voldown 数値(保存用)
        public byte _ssg_voldown = 0;// PSG voldown 数値(保存用)
        public byte _pcm_voldown = 0;// PCM voldown 数値(保存用)
        public byte _rhythm_voldown = 0;//RHYTHM voldown 数値(保存用)
        public byte _pcm86_vol = 0;// PCM86の音量をSPBに合わせるか? (保存用)
        public byte mstart_flag = 0;//mstartする時に１にするだけのflag
        public byte[] mus_filename = new byte[13];// 曲のFILE名バッファ
        public byte mmldat_lng = 0;//曲データバッファサイズ(KB)
        public byte voicedat_lng = 0;// 音色データバッファサイズ(KB)
        public byte effecdat_lng = 0;// 効果音データバッファサイズ(KB)
        public byte rshot_bd = 0;// リズム音源 shot inc flag(BD)
        public byte rshot_sd = 0;// リズム音源 shot inc flag(SD)
        public byte rshot_sym = 0;// リズム音源 shot inc flag(CYM)
        public byte rshot_hh = 0;// リズム音源 shot inc flag(HH)
        public byte rshot_tom = 0;// リズム音源 shot inc flag(TOM)
        public byte rshot_rim = 0;// リズム音源 shot inc flag(RIM)
        public byte rdump_bd = 0;// リズム音源 dump inc flag(BD)
        public byte rdump_sd = 0;// リズム音源 dump inc flag(SD)
        public byte rdump_sym = 0;// リズム音源 dump inc flag(CYM)
        public byte rdump_hh = 0;// リズム音源 dump inc flag(HH)
        public byte rdump_tom = 0;// リズム音源 dump inc flag(TOM)
        public byte rdump_rim = 0;// リズム音源 dump inc flag(RIM)
        public byte ch3mode = 0;// ch3 Mode
        public byte ch3mode_push = 0;// ch3 Mode(効果音発音時用push領域)
        public byte ppz_voldown = 0;// PPZ8 voldown 数値
        public byte _ppz_voldown = 0;//PPZ8 voldown 数値(保存用)
        public int ppz_call_ofs = 0;// PPZ8call用 far call address
        public int ppz_call_seg = 0;// seg値はPPZ8常駐checkを兼ねる,0で非常駐
        public byte p86_freq = 8;//PMD86のPCM再生周波数
                                 //if	pcm* board2
        public int p86_freqtable = 0;//offset pcm_tune_data
                                     //else
                                     //public int p86_freqtable = 0;// PMD86のPCM再生周波数table位置
                                     //endif
        public byte adpcm_emulate = 0;// PMDPPZEでADPCMエミュレート中か


        //PMD.ASM 260-277
        //;==============================================================================
        //;	定数
        //;==============================================================================
        public int ms_cmd = 0x000;// ８２５９マスタポート
        public int ms_msk = 0x002;// ８２５９マスタ／マスク
        public int sl_cmd = 0x008;// ８２５９スレーブポート
        public int sl_msk = 0x00a;// ８２５９スレーブ／マスク



        //PMD.ASM 279-306
        //;==============================================================================
        //;	Program Start
        //;==============================================================================
        //int60_head:	jmp short int60_main
        //db	'PMD'	;+2  常駐チェック用
        //db  vers	;+5
        //db verc;+6
        public int int60ofs;//	?	;+7
        public int int60seg;//	?	;+9
        public int int5ofs;//	?	;+11
        public int int5seg;//	?	;+13
        public int maskpush;//	?	;+15
        public int vector;//	?	;+16
        public int int_level;//	?	;+18

        public int _p = 2;
        public int _m = 3;
        public int _d = 4;
        public int _vers = 5;
        public int _verc = 6;
        public int _int60ofs = 7;
        public int _int60seg = 9;
        public int _int5ofs = 11;
        public int _int5seg = 13;
        public int _maskpush = 15;
        public int _vector = 16;
        public int _int_level = 18;



        //7972-8381
        //;==============================================================================
        //;	WORK AREA
        //;==============================================================================
        public ushort fm_port1;// w	FM音源 I/O port work(1)
        public ushort fm_port2;// w FM音源 I/O port work(2)
        public ushort ds_push;// w INT60用 ds push
        public ushort dx_push;// w INT60用 dx push
        public byte ah_push;// b INT60用 ah push
        public byte al_push;// b INT60用 al push
        public byte partb;//b 処理中パート番号
        public byte tieflag;//b &のフラグ
        public byte volpush_flag;//b 次の１音音量down用のflag
        public byte rhydmy;//b R part ダミー演奏データ
        public byte fmsel;//b FM 表か裏か flag
        public byte omote_key1;//b FM keyondata表1
        public byte omote_key2;//b  FM keyondata表2
        public byte omote_key3;//b FM keyondata表3
        public byte ura_key1;//b FM keyondata裏1
        public byte ura_key2;//b FM keyondata裏2
        public byte ura_key3;//b FM keyondata裏3
        public byte loop_work;//b Loop Work
        public byte ppsdrv_flag;//b ppsdrv flag
        public ushort prgdat_adr2;// w 曲データ中音色データ先頭番地(効果音用)
        public ushort pcmrepeat1;// w PCMのリピートアドレス1
        public ushort pcmrepeat2;// w PCMのリピートアドレス2
        public ushort pcmrelease;// w PCMのRelease開始アドレス
        public byte lastTimerAtime;// b 一個前の割り込み時のTimerATime値
        public byte music_flag;// b B0:次でMSTART 1:次でMSTOP のFlag
        public byte slotdetune_flag;// b FM3 Slot Detuneを使っているか
        public byte slot3_flag;// b FM3 Slot毎 要効果音モードフラグ
        public ushort eoi_adr;// w EOIをsendするI/Oアドレス
        public byte eoi_data;// b EOI用のデータ
        public ushort mask_adr;// w MaskをするI/Oアドレス
        public byte mask_data;// b Mask用のデータ(OrでMask)
        public byte mask_data2;// b Mask用のデータ(AndでMask解除)
        public ushort ss_push;// w FMint中 SSのpush
        public ushort sp_push;// w FMint中 SPのpush
        public byte fm3_alg_fb;// b FM3chの最後に定義した音色のalg/fb
        public byte af_check;// b FM3chのalg/fbを設定するかしないかflag
        public byte ongen;// b 音源 0=無し/2203 1=2608
        public byte lfo_switch;// b	局所LFOスイッチ

        //rhydat:					; ドラムス用リズムデータ
        //	;	PT PAN/VOLUME KEYON

        //    db	18h,11011111b,	00000001b	;バス
        //    db	19h,11011111b,	00000010b	;スネア
        //    db	1ch,01011111b,	00010000b	;タム[LOW]
        //    db	1ch,11011111b,	00010000b	;タム[MID]
        //    db	1ch,10011111b,	00010000b	;タム[HIGH]
        //    db	1dh,11010011b,	00100000b	;リム
        //    db	19h,11011111b,	00000010b	;クラップ
        //    db	1bh,10011100b,	10001000b	;Cハイハット
        //    db	1ah,10011101b,	00000100b	;Oハイハット
        //    db	1ah,11011111b,	00000100b	;シンバル
        //    db	1ah,01011110b,	00000100b	;RIDEシンバル

        //    even
        //;
        //        open_work label   byte
        //      mmlbuf      dw?		;Musicdataのaddress+1
        //tondat dw	?		; Voicedataのaddress
        //efcdat      dw?		;FM Effecdataのaddress
        //fm1_port1 dw	?		; FM音源 I/O port(表1)
        //fm1_port2 dw	?		; FM音源 I/O port(表2)
        //fm2_port1 dw	?		; FM音源 I/O port(裏1)
        //fm2_port2 dw	?		; FM音源 I/O port(裏2)
        //fmint_ofs dw	?		; FM割り込みフックアドレス offset
        //fmint_seg dw	?		; FM割り込みフックアドレス address
        //efcint_ofs dw	?		; 効果音割り込みフックアドレス offset
        //efcint_seg dw	?		; 効果音割り込みフックアドレス address
        //prgdat_adr dw	?		; 曲データ中音色データ先頭番地
        //radtbl      dw?		;R part offset table 先頭番地
        //rhyadr      dw?		;R part 演奏中番地
        //rhythmmask  db?		;Rhythm音源のマスク x8c/10hのbitに対応
        //board       db?		;FM音源ボードあり／なしflag
        //key_check   db?		;ESC/GRPH key Check flag
        //fm_voldown db	?		; FM voldown 数値
        //ssg_voldown db?		;PSG voldown 数値
        //pcm_voldown db?		;PCM voldown 数値
        //rhythm_voldown  db?		;RHYTHM voldown 数値
        //prg_flg     db?		;曲データに音色が含まれているかflag
        //x68_flg     db?		;OPM flag
        //status db	?		; status1
        //status2     db?		;status2
        //tempo_d     db?		;tempo(TIMER-B)
        //fadeout_speed db	?		; Fadeout速度
        //fadeout_volume  db?		;Fadeout音量
        //tempo_d_push    db?		;tempo(TIMER-B) / 保存用
        //syousetu_lng    db?		;小節の長さ
        //opncount    db?		;最短音符カウンタ
        //TimerAtime  db?		;TimerAカウンタ
        //effflag     db?		;PSG効果音発声on/off flag
        //psnoi db	?		; PSG noise周波数
        //psnoi_last db	?		; PSG noise周波数(最後に定義した数値)
        //fm_effec_num db	?		; 発声中のFM効果音番号
        //fm_effec_flag   db?		;FM効果音発声中flag(1)
        //disint db	?		; FM割り込み中に割り込みを禁止するかflag
        //pcmflag     db?		;PCM効果音発声中flag
        //pcmstart    dw?		;PCM音色のstart値
        //pcmstop     dw?		;PCM音色のstop値
        //pcm_effec_num   db?		;発声中のPCM効果音番号
        //_pcmstart   dw?		;PCM効果音のstart値
        //_pcmstop    dw?		;PCM効果音のstop値
        //_voice_delta_n  dw?		;PCM効果音のdelta_n値
        //_pcmpan     db?		;PCM効果音のpan
        //_pcm_volume db?		;PCM効果音のvolume
        //rshot_dat   db?		;リズム音源 shot flag
        //rdat        db	6 dup(?); リズム音源 音量/パンデータ
        //rhyvol      db	00111100b	;リズムトータルレベル
        //kshot_dat   dw?		;ＳＳＧリズム shot flag
        //ssgefcdat   dw efftbl; PSG Effecdataのaddress
        //ssgefclen dw  efftblend-efftbl;PSG Effecdataの長さ
        //play_flag db	?		; play flag
        //pause_flag db	?		; pause flag
        //fade_stop_flag db	0		; Fadeout後 MSTOPするかどうかのフラグ
        //kp_rhythm_flag db	?		; K/RpartでRhythm音源を鳴らすかflag
        //TimerBflag  db	0		;TimerB割り込み中？フラグ
        //TimerAflag  db	0		;TimerA割り込み中？フラグ
        //int60flag   db	0		;INT60H割り込み中？フラグ
        //int60_result    db	0		;INT60Hの実行ErrorFlag
        //pcm_gs_flag db?		;ADPCM使用 許可フラグ(0で許可)
        //esc_sp_key db	?		; ESC +?? Key Code
        //grph_sp_key db	?		; GRPH+?? Key Code
        //rescut_cant db	?		; 常駐解除禁止フラグ
        // slot_detune1    dw?		;FM3 Slot Detune値 slot1
        //slot_detune2 dw	?		; FM3 Slot Detune値 slot2
        //slot_detune3 dw	?		; FM3 Slot Detune値 slot3
        //slot_detune4 dw	?		; FM3 Slot Detune値 slot4
        //wait_clock dw	?		; FM ADDRESS-DATA間 Loop $の回数
        //wait1_clock dw?		;loop $ １個の速度
        //ff_tempo    db?		;早送り時のTimerB値
        //pcm_access  db	0		;PCMセット中は 1
        //TimerB_speed db	?		; TimerBの現在値(=ff_tempoならff中)
        //fadeout_flag db	?		; 内部からfoutを呼び出した時1
        //adpcm_wait  db?		;ADPCM定義の速度
        //revpan      db?		;PCM86逆走flag
        //pcm86_vol   db?		;PCM86の音量をSPBに合わせるか?
        //syousetu    dw?		;小節カウンタ
        //int5_flag   db	0		;FM音源割り込み中？フラグ
        //port22h     db	0		;OPN-PORT 22H に最後に出力した値(hlfo)
        //tempo_48 db	?		; 現在のテンポ(clock= 48 tの値)
        //tempo_48_push db	?		; 現在のテンポ(同上/保存用)
        //rew_sp_key db	?		; GRPH+?? (rew) Key Code
        //intfook_flag    db?		;int_fookのflag B0:TB B1:TA
        //skip_flag   db?		;normal:0 前方SKIP中:1 後方SKIP中:2
        //_fm_voldown db	?		; FM voldown 数値(保存用)
        //_ssg_voldown db	?		; PSG voldown 数値(保存用)
        //_pcm_voldown db	?		; PCM voldown 数値(保存用)
        //_rhythm_voldown db	?		; RHYTHM voldown 数値(保存用)
        //_pcm86_vol db	?		; PCM86の音量をSPBに合わせるか? (保存用)
        //mstart_flag db	0		;mstartする時に１にするだけのflag
        //mus_filename    db	13 dup(0); 曲のFILE名バッファ
        //mmldat_lng  db?		;曲データバッファサイズ(KB)
        //voicedat_lng db	?		; 音色データバッファサイズ(KB)
        //effecdat_lng db	?		; 効果音データバッファサイズ(KB)
        //rshot_bd db	?		; リズム音源 shot inc flag(BD)
        //rshot_sd db	?		; リズム音源 shot inc flag(SD)
        //rshot_sym db	?		; リズム音源 shot inc flag(CYM)
        //rshot_hh db	?		; リズム音源 shot inc flag(HH)
        //rshot_tom db	?		; リズム音源 shot inc flag(TOM)
        //rshot_rim db	?		; リズム音源 shot inc flag(RIM)
        //rdump_bd db	?		; リズム音源 dump inc flag(BD)
        //rdump_sd db	?		; リズム音源 dump inc flag(SD)
        //rdump_sym db	?		; リズム音源 dump inc flag(CYM)
        //rdump_hh db	?		; リズム音源 dump inc flag(HH)
        //rdump_tom db	?		; リズム音源 dump inc flag(TOM)
        //rdump_rim db	?		; リズム音源 dump inc flag(RIM)
        //ch3mode db	?		; ch3 Mode
        //ch3mode_push db	?		; ch3 Mode(効果音発音時用push領域)
        //ppz_voldown db	?		; PPZ8 voldown 数値
        // _ppz_voldown    db?		;PPZ8 voldown 数値(保存用)
        //ppz_call_ofs dw	?		; PPZ8call用 far call address
        //ppz_call_seg dw	?		; seg値はPPZ8常駐checkを兼ねる,0で非常駐
        //p86_freq    db	8		;PMD86のPCM再生周波数
        //if	pcm* board2
        //p86_freqtable dw  offset pcm_tune_data
        //else
        //p86_freqtable dw	0		; PMD86のPCM再生周波数table位置
        //endif
        //adpcm_emulate db	0		; PMDPPZEでADPCMエミュレート中か

        //;	演奏中のデータエリア

        public class partWork
        { //qq  struc
            public ushort address;// w?	; 2 ｴﾝｿｳﾁｭｳ ﾉ ｱﾄﾞﾚｽ
            public ushort partloop;// w? ; 2 ｴﾝｿｳ ｶﾞ ｵﾜｯﾀﾄｷ ﾉ ﾓﾄﾞﾘｻｷ
            public byte leng;// b? ; 1 ﾉｺﾘ LENGTH
            public byte qdat;// b? ; 1 gatetime(q/Q値を計算した値)
            public ushort fnum;// w? ; 2 ｴﾝｿｳﾁｭｳ ﾉ BLOCK/FNUM
                             //detune      dw?       ; 2 ﾃﾞﾁｭｰﾝ
                             //lfodat      dw?       ; 2 LFO DATA
                             //porta_num dw	?	; 2 ポルタメントの加減値（全体）
                             //porta_num2 dw	?	; 2 ポルタメントの加減値（一回）
                             //porta_num3 dw	?	; 2 ポルタメントの加減値（余り）
            public byte volume;//b? ; 1 VOLUME
                               //shift       db?       ; 1 ｵﾝｶｲ ｼﾌﾄ ﾉ ｱﾀｲ
                               //delay db	?       ; 1 LFO[DELAY]
                               //speed       db?       ; 1	[SPEED]
                               //step db	?       ; 1	[STEP]
                               //time db	?       ; 1	[TIME]
                               //delay2 db	?       ; 1	[DELAY_2]
                               //speed2 db	?       ; 1	[SPEED_2]
                               //step2 db	?       ; 1	[STEP_2]
                               //time2 db	?       ; 1	[TIME_2]
            public byte lfoswi;// b? ; 1 LFOSW.B0/tone B1/vol B2/同期 B3/porta
                               //    ;          B4/tone B5/vol B6/同期
            public byte volpush;// b? ; 1 Volume PUSHarea
            public byte mdepth;// b? ; 1 M depth
            public byte mdspd;// b? ; 1 M speed
            public byte mdspd2;// b? ; 1 M speed_2
            public byte envf;// b? ; 1 PSG ENV. [START_FLAG] / -1でextend
                               //eenv_count  db?   ; 1 ExtendPSGenv/No=0 AR=1 DR=2 SR=3 RR=4
                               //eenv_ar db	?	; 1 		/AR		/旧pat
                               //eenv_dr     db?	; 1		/DR		/旧pv2
                               //eenv_sr     db?	; 1		/SR		/旧pr1
                               //eenv_rr     db?	; 1		/RR		/旧pr2
                               //eenv_sl     db?	; 1		/SL
                               //eenv_al     db?	; 1		/AL
                               //eenv_arc    db?	; 1		/ARのカウンタ	/旧patb
                               //eenv_drc    db?	; 1		/DRのカウンタ
                               //eenv_src    db?	; 1		/SRのカウンタ	/旧pr1b
                               //eenv_rrc    db?	; 1		/RRのカウンタ	/旧pr2b
                               //eenv_volume db?	; 1		/Volume値(0～15)/旧penv
                               //extendmode  db?	; 1 B1/Detune B2/LFO B3/Env Normal/Extend
            public byte fmpan;// b? ; 1 FM Panning + AMD + PMD
            public byte psgpat;// b? ; 1 PSG PATTERN[TONE / NOISE / MIX]
            public byte voicenum;// b? ; 1 音色番号
            public byte loopcheck;// b? ; 1 ループしたら１ 終了したら３
            public byte carrier;// b? ; 1 FM Carrier
            public byte slot1;// b? ; 1 SLOT 1 ﾉ TL
            public byte slot3;// b? ; 1 SLOT 3 ﾉ TL
            public byte slot2;// b? ; 1 SLOT 2 ﾉ TL
            public byte slot4;// b? ; 1 SLOT 4 ﾉ TL
            public byte slotmask;// b? ; 1 FM slotmask
            public byte neiromask;// b? ; 1 FM 音色定義用maskdata
            public byte lfo_wave;// b? ; 1 LFOの波形
            public byte partmask;// b 1 PartMask b0:通常 b1:効果音 b2:NECPCM用
                                 //          ;   b3:none b4:PPZ/ADE用 b5:s0時 b6:m b7:一時
            public byte keyoff_flag;// b? ; 1 KeyoffしたかどうかのFlag
            public byte volmask;// b? ; 1 音量LFOのマスク
            public byte qdata;// b? ; 1 qの値
            public byte qdatb;// b?	; 1 Qの値
            public byte hldelay;// b? ; 1 HardLFO delay
            public byte hldelay_c;// b? ; 1 HardLFO delay Counter
                                  //_lfodat     dw?       ; 2 LFO DATA
                                  //_delay db	?       ; 1 LFO[DELAY]
                                  //_speed      db?       ; 1	[SPEED]
                                  //_step db	?       ; 1	[STEP]
                                  //_time db	?       ; 1	[TIME]
                                  //_delay2 db	?       ; 1	[DELAY_2]
                                  //_speed2 db	?       ; 1	[SPEED_2]
                                  //_step2 db	?       ; 1	[STEP_2]
                                  //_time2 db	?       ; 1	[TIME_2]
                                  //_mdepth db	?	; 1 M depth
                                  //_mdspd db	?	; 1 M speed
                                  //_mdspd2 db	?	; 1 M speed_2
                                  //_lfo_wave db	?	; 1 LFOの波形
                                  //_volmask    db?	; 1 音量LFOのマスク
            public byte mdc;// b? ; 1 M depth Counter(変動値)
            public byte mdc2;// b? ; 1 M depth Counter
            public byte _mdc;// b? ; 1 M depth Counter(変動値)
            public byte _mdc2;// b? ; 1 M depth Counter
            public byte onkai;//b 1 演奏中の音階データ(0ffh:rest)
            public byte sdelay;//b?; 1 Slot delay
            public byte sdelay_c;//b? ; 1 Slot delay counter
            public byte sdelay_m;//b? ; 1 Slot delay Mask
            public byte alg_fb;//b? ; 1 音色のalg/fb
            public byte keyon_flag;// b 1 新音階/休符データを処理したらinc
            public byte qdat2;// b? ; 1 q 最低保証値
            public ushort fnum2;// w? ; 2 ppz8/pmd86用fnum値上位
            public byte onkai_def;// b 1 演奏中の音階データ(転調処理前 / ?fh:rest)
            public byte shift_def;// b? ; 1 マスター転調値
            public byte qdat3;// b? ; 1 q Random

            //        db?	; dummy
        }//qq  ends

        //qqq struc
        //      db  offset eenv_ar dup(?)
        //pat db	?	; 1 旧SSGENV	/Normal pat
        //pv2 db	?	; 1		/Normal pv2
        //pr1 db	?	; 1		/Normal pr1
        //pr2 db	?	; 1		/Normal pr2

        //        db?
        //        db	?
        //patb db	?	; 1		/Normal patb

        //        db?
        //pr1b        db?	; 1		/Normal pr1b
        //pr2b db	?	; 1		/Normal pr2b
        //penv db	?	; 1		/Normal penv
        //qqq ends

        public int max_part1;//０クリアすべきパート数
        public int max_part2;//初期化すべきパート数

        //fm      equ	0
        //fm2 equ	1
        //psg equ	2
        //rhythm equ	3


        //    even

        //    dw  open_work

        public int[] part_data_table;

        //FM1-3
        public int part1;
        public int part2;
        public int part3;

        //FM4-6
        public int part4;
        public int part5;
        public int part6;

        //効果音モード
        public int part3b;
        public int part3c;
        public int part3d;

        //pps?
        public int part7;
        public int part8;
        public int part9;
        public int part10;
        public int part11;

        //ppz 
        public int part10a;
        public int part10b;
        public int part10c;
        public int part10d;
        public int part10e;
        public int part10f;
        public int part10g;
        public int part10h;

        //効果音
        public int part_e;

        public partWork[] partWk;
        //ノーマル
        // 1,2,3, 3b,3c,3d, 7,8,9,10,11, e
        //board2
        // 1,2,3,4,5,6, 7,8,9,10,11, 3b,3c,3d, e
        //ppz(ppzはboard2を兼ねる)
        // 1,2,3,4,5,6, 7,8,9,10,11, 3b,3c,3d, 10a,10b,10c,10d,10e,10f,10g,10h ,e


        //    even
        //pcm_table   label word
        //if	board2
        // if	adpcm
        //  ife   ademu
        //pcmends     dw	26H	;最初のstartは26Hから
        //pcmadrs     dw	2*256 dup(0)
        //pcmfilename db	128 dup(0)
        //  endif
        // endif
        // if	pcm
        //pcmst_ofs   dw	0
        //pcmst_seg dw	0
        //pcmadrs db	6*256 dup(0)
        // endif
        //endif

        //        db	"ここはＳＴＡＣＫエリアです。いつ"
        //		db	"もＰＭＤをご愛用して下さっている"
        //		db	"方々、どうもありがとうございます"
        //		db	"(^^)。何かバグらしき物が見つかり"
        //		db	"ましたら、些細な事でも構いません"
        //		db	"ので、是非私までご一報、お願いし"
        //		db	"ますね(^^)。→PMDBBS [xx(xxxx)xx"
        //		db	"xx] @PMD ボードまで     by KAJA."
        //_stack:
        //dataarea label   word
        //     db	0		;
        //        dw	12 dup(18h); 初期データ
        //   db	80h		;

        public byte[] fmoff_nef = new byte[] { 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 0xff };
        public byte[] fmoff_ef = new byte[] { 0, 1, 4, 5, 8, 9, 12, 13, 0xff };


        //EFCDRV.ASM
        public ushort effadr;// w effect address
        public ushort eswthz;// w トーンスゥイープ周波数
        public ushort eswtst;// w トーンスゥイープ増分
        public byte effcnt;// b effect count
        public byte eswnhz;// b ノイズスゥイープ周波数
        public byte eswnst;// b ノイズスゥイープ増分
        public byte eswnct;// b ノイズスゥイープカウント
        public byte effon;// b 効果音 発音中
        public byte psgefcnum;// b 効果音番号
        public byte hosei_flag;// b ppsdrv 音量/音程補正をするかどうか
        public byte last_shot_data;// b 最後に発音させたPPSDRV音色


        //PCMDRV86.ASM
        //;==============================================================================
        //;	Datas
        //;==============================================================================
        //trans_size equ	256	;1回の転送byte数
        //play86_flag db	0	;発音中? flag
        //trans_flag db	0	; 転送するdataが残っているか? flag
        //start_ofs dw	0	; 発音中PCMデータ番地(offset下位)
        //start_ofs2 dw	0	; 発音中PCMデータ番地(offset上位)
        //size1 dw	0	; 残りサイズ(下位word)
        //size2 dw	0	; 残りサイズ(上位word)
        //_start_ofs dw	0	; 発音開始PCMデータ番地(offset下位)
        //_start_ofs2 dw	0	; 発音開始PCMデータ番地(offset上位)
        //_size1 dw	0	; PCMデータサイズ(下位word)
        //_size2 dw	0	; PCMデータサイズ(上位word)
        //addsize1 db	0	; PCMアドレス加算値(整数部)
        //addsize2 dw	0	; PCMアドレス加算値(小数点部)
        //addsizew dw	0	; PCMアドレス加算値(小数点部, 転送中work)
        //repeat_ofs dw	0	; リピート開始位置(offset下位)
        //repeat_ofs2 dw	0	; リピート開始位置(offset上位)
        //repeat_size1 dw	0	; リピート後のサイズ(下位word)
        //repeat_size2 dw	0	; リピート後のサイズ(上位word)
        //release_ofs dw	0	; リリース開始位置(offset下位)
        //release_ofs2 dw	0	; リリース開始位置(offset上位)
        //release_size1 dw	0	; リリース後のサイズ(下位word)
        //release_size2 dw	0	; リリース後のサイズ(上位word)
        //repeat_flag db	0	; リピートするかどうかのflag
        // release_flag1   db	0	;リリースするかどうかのflag
        // release_flag2   db	0	;リリースしたかどうかのflag
        public byte pcm86_pan_flag = 0;// b 0 ;パンデータ１(bit0= 左 / bit1 = 右 / bit2 = 逆)
//pcm86_pan_dat db	0	; パンデータ２(音量を下げるサイドの音量値)

//; pan_flagによる転送table
//trans_table dw double_trans, left_trans

//        dw right_trans, double_trans

//        dw double_trans_g, left_trans_g

//        dw right_trans_g, double_trans_g

//; 周波数table Include

//    include tunedata.inc




        public PW()
        {
            fmvd_init = (va + board2 != 0) ? 0 : 16;

            if (va != 0)
            {
                ms_cmd = 0x188;// ８２５９マスタポート
                ms_msk = 0x18a;// ８２５９マスタ／マスク
                sl_cmd = 0x184;// ８２５９スレーブポート
                sl_msk = 0x186;// ８２５９スレーブ／マスク
            }

            if (board2 == 0)
            {
                //ノーマル
                partWk = new partWork[3 + 3 + 5 + 1];
                part3b = 3; partWk[part3b] = new partWork();
                part3c = 4; partWk[part3c] = new partWork();
                part3d = 5; partWk[part3d] = new partWork();
                part7 = 6; partWk[part7] = new partWork();
                part8 = 7; partWk[part8] = new partWork();
                part9 = 8; partWk[part9] = new partWork();
                part10 = 9; partWk[part10] = new partWork();
                part11 = 10; partWk[part11] = new partWork();
                part_e = 11; partWk[part_e] = new partWork();

                max_part1 = 11;//０クリアすべきパート数
                max_part2 = 11;//初期化すべきパート数
            }
            else
            {
                //board2
                if (ppz == 0)
                {
                    partWk = new partWork[3 + 3 + 5 + 3 + 1];
                    part_e = 14; partWk[part_e] = new partWork();

                    max_part1 = 14;//０クリアすべきパート数
                    max_part2 = 11;//初期化すべきパート数
                }
                else
                {
                    partWk = new partWork[3 + 3 + 5 + 3 + 8 + 1];
                    part10a = 14; partWk[part10a] = new partWork();
                    part10b = 15; partWk[part10b] = new partWork();
                    part10c = 16; partWk[part10c] = new partWork();
                    part10d = 17; partWk[part10d] = new partWork();
                    part10e = 18; partWk[part10e] = new partWork();
                    part10f = 19; partWk[part10f] = new partWork();
                    part10g = 20; partWk[part10g] = new partWork();
                    part10h = 21; partWk[part10h] = new partWork();
                    part_e = 22; partWk[part_e] = new partWork();

                    max_part1 = 14 + 8;//０クリアすべきパート数
                    max_part2 = 11;//初期化すべきパート数
                }
                part4 = 3; partWk[part4] = new partWork();
                part5 = 4; partWk[part5] = new partWork();
                part6 = 5; partWk[part6] = new partWork();
                part7 = 6; partWk[part7] = new partWork();
                part8 = 7; partWk[part8] = new partWork();
                part9 = 8; partWk[part9] = new partWork();
                part10 = 9; partWk[part10] = new partWork();
                part11 = 10; partWk[part11] = new partWork();
                part3b = 11; partWk[part3b] = new partWork();
                part3c = 12; partWk[part3c] = new partWork();
                part3d = 13; partWk[part3d] = new partWork();
            }
            part1 = 0; partWk[part1] = new partWork();
            part2 = 1; partWk[part2] = new partWork();
            part3 = 2; partWk[part3] = new partWork();
        }

        public void ZeroClearPartWk(partWork partWork)
        {
            throw new NotImplementedException();
        }

    }
}