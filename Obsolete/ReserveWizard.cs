using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace magicAnime
{
	partial class ReserveWizard : Form
	{
		AnimeRecord animeRecord;
		public ReserveWizard()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(AnimeRecord animeRecord)
		{
			if (animeRecord == null)
				throw new NotImplementedException();

			this.animeRecord = animeRecord;

			registTitleLabel.Text = string.Format(
				"{0:0} {1:0}話",
				animeRecord.Parent.title,
				animeRecord.StoryNumber);

			tvStationLabel.Text = animeRecord.Parent.tvStation;

			return ShowDialog();
		}

		private void nextButton_Click(object sender, EventArgs e)
		{/*
			//
			// iEPG経由でmAgicTVに予約登録する
			//

			Scheduler scheduler = new iEPGScheduler();

			animeRecord.Reserve(scheduler, null);

			System.Threading.Thread.Sleep( 500 );

			//
			// mAgicTVの予約エントリから登録したエントリを探す
			//
			mAgicReservation registReservation = null;

			mAgicScheduler.CallbackEnumScheduleEntries func
					= delegate (mAgicReservation reservation)
			{
				//
				// 予約タイトルの@以降の一意な文字列で判断する
				//
				string temp1, temp2;

				temp1 = reservation.title.Trim();
				temp2 = animeRecord.GetReserveTitle().Trim();
				
				temp1 = temp1.Substring(temp1.LastIndexOf('@'));
				temp2 = temp2.Substring(temp2.LastIndexOf('@'));

				if (temp1.Equals(temp2))	// 見つかった
				{
					registReservation = reservation;
				}

				return false;
			};

			mAgicScheduler.EnumScheduleEntries(func);

			if (registReservation == null)
			{
				throw new NotImplementedException("mAgicTVへの予約登録に失敗しました");
			}

			//
			// 予約データをテンプレートとしてファイルに保存する
			//

			string templateFilename;

			templateFilename = ReserveManager.GetReservationTemplateFileName(animeRecord.Parent);

			registReservation.Write( templateFilename);

			this.DialogResult = DialogResult.OK;
			Close();*/

		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			Close();
		}

	}

}


