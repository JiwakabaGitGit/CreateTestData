using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreateTransferMap
{

    public partial class Form1 : Form
    {
		private const int FRAME_LENGTH = 32;
		private const string WAFER_ID = "wsafer_id";
		private const string FRAME_BASE_ID = "frame_id_";
		public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				// テキストボックスからファイル名 (ファイルパス) を取得
				string fileName = this.textBox1.Text;

				// SaveFileDialog クラスのインスタンスを生成
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					// ファイルの種類リストを設定
					saveFileDialog.Filter = "テキストファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";

					// テキストボックスにファイル名 (ファイルパス) が設定されている場合は
					// ファイルのディレクトリー (フォルダー) を初期表示する
					if (fileName != string.Empty)
					{
						// FileInfo クラスのインスタンスを生成
						FileInfo fileInfo = new FileInfo(fileName);
						// ディレクトリー名 (ディレクトリーパス) を取得
						string directoryName = fileInfo.DirectoryName;
						// 存在する場合は InitialDirectory プロパティに設定
						if (Directory.Exists(directoryName))
						{
							saveFileDialog.InitialDirectory = directoryName;
						}
					}

					// ダイアログを表示
					DialogResult dialogResult = saveFileDialog.ShowDialog();
					if (dialogResult == DialogResult.Cancel)
					{
						// キャンセルされたので終了
						return;
					}

					// 選択されたファイル名 (ファイルパス) をテキストボックスに設定
					this.textBox1.Text = saveFileDialog.FileName;
					this.WriteTransferMap( saveFileDialog.FileName );
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void WriteTransferMap( string fileName )
		{
			try
			{
				//ファイルをオープンする
				using ( StreamWriter sw = new StreamWriter( fileName, false ) )
				{
					// WaferID
					string waferId = WAFER_ID.PadRight( FRAME_LENGTH, ' ' );
					sw.Write( waferId );
					// FrameID
					string frameId = this.textTextBoxWaferID.Text.PadRight( FRAME_LENGTH, ' ' );
					sw.Write( frameId );

					sw.Write( "xxxx" );
					sw.Write( "xxxx" );
					sw.Write( "xxxx" );

					// チップ配列数
					int chipArrayX = decimal.ToInt32( this.numericUpDown_X.Value ) * decimal.ToInt32(this.numericUpDown_SbsX.Value);
					sw.Write( chipArrayX.ToString("X4") );
					int chipArrayY = decimal.ToInt32( this.numericUpDown_Y.Value ) * decimal.ToInt32( this.numericUpDown_SbsY.Value ) * decimal.ToInt32( this.numericUpDown_Stack.Value );
					sw.Write( chipArrayY.ToString( "X4" ) );

					for(int i = 0; i < 3; i++ )
                    {
						for ( int y = 0; y < 4; y++ )
						{
							sw.Write( "xxx/" );
						}
					}

					// 基板配列数XY
					int boardArrayX = decimal.ToInt32( this.numericUpDown_X.Value );
					sw.Write( boardArrayX.ToString( "X4" ) );
					int boardArrayY = decimal.ToInt32( this.numericUpDown_Y.Value );
					sw.Write( boardArrayY.ToString( "X4" ) );

					// スタック段数
					int stuckNumber = decimal.ToInt32( this.numericUpDown_Stack.Value );
					sw.Write( stuckNumber.ToString( "X4" ) );

					// アイランド配列数XY(SBS)
					int islandArrayX = decimal.ToInt32( this.numericUpDown_SbsX.Value );
					sw.Write( islandArrayX.ToString( "X4" ) );
					int islandArrayY = decimal.ToInt32( this.numericUpDown_SbsY.Value );
					sw.Write( islandArrayY.ToString( "X4" ) );

					//	基板数
					int substraiteNumber = decimal.ToInt32( this.numericUpDown_SubstNumber.Value );
					sw.Write( substraiteNumber.ToString( "X4" ) );

					int iSubstCounter = 1;
					int iSequenceOrder = 0;
					for ( iSubstCounter = 1; iSubstCounter < substraiteNumber; iSubstCounter++ )
                    {
						string substraiteID = FRAME_BASE_ID + iSubstCounter.ToString( "X4" );
						sw.Write( substraiteID.PadRight( FRAME_LENGTH, ' ' ) );

						// チップ数
						int iChipNumber = chipArrayX * chipArrayY;
						sw.Write( iChipNumber.ToString( "X4" ) );

						for ( int iTxIndex = 1; iTxIndex <= chipArrayX; iTxIndex++ )
                        {
							for ( int i = 0; i < boardArrayY; i++ )
                            {
								for ( int j = 0; j < islandArrayY; j++ )
                                {
									for ( int iZ = 1; iZ <= stuckNumber; iZ++ )
									{
										int iFx = iSequenceOrder;
										sw.Write( iFx.ToString( "X4" ) );
										int iFy = iSubstCounter;
										sw.Write( iFy.ToString( "X4" ) );

										sw.Write( iTxIndex.ToString( "X4" ) );
										int iTyIndex = ( islandArrayY * stuckNumber ) *  j + ( stuckNumber * i ) + iZ;
										sw.Write( iTyIndex.ToString( "X4" ) );
										sw.Write( iZ.ToString( "X4" ) );

										iSequenceOrder++;
									}
								}
                            }
                        }
                    }

					string substraiteLastId = FRAME_BASE_ID + iSubstCounter.ToString( "X4" );
					sw.Write( substraiteLastId.PadRight( FRAME_LENGTH, ' ' ) );

					//	最終基板チップ基板数
					int chipRemain = decimal.ToInt32( this.numericUpDown_remainChip.Value );
					if ( chipArrayX * chipArrayY < chipRemain )
                    {
						chipRemain = chipArrayX * chipArrayY;
					}

					sw.Write( chipRemain.ToString( "X4" ) );

					for ( int iTxIndex = 1; iTxIndex <= chipArrayX; iTxIndex++ )
					{
						if ( chipRemain < 1 )
						{
							break;
						}
						
						for ( int i = 0; i < boardArrayY; i++ )
						{
							if ( chipRemain < 1 )
							{
								break;
							}

							for ( int j = 0; j < islandArrayY; j++ )
							{
								if ( chipRemain < 1 )
								{
									break;
								}

								for ( int iZ = 1; iZ <= stuckNumber; iZ++ )
								{
									if ( chipRemain < 1 )
                                    {
										break;
                                    }
									int iFx = iSequenceOrder;
									sw.Write( iFx.ToString( "X4" ) );
									int iFy = iSubstCounter;
									sw.Write( iFy.ToString( "X4" ) );

									sw.Write( iTxIndex.ToString( "X4" ) );
									int iTyIndex = ( islandArrayY * stuckNumber ) * j + ( stuckNumber * i ) + iZ;
									sw.Write( iTyIndex.ToString( "X4" ) );
									sw.Write( iZ.ToString( "X4" ) );

									iSequenceOrder++;

									chipRemain--;
								}
							}
						}
					}
				}
			}
			catch ( Exception ex )
			{
				MessageBox.Show( ex.Message );
			}
		}
	}
}
