using System;
using System.Collections.Generic;
using System.Text;

namespace RadComboBoxTest
{
    class ItemBatchInternal
    {
        private string _castingNumber;

        private int _countAno;

        private int _countBillett;

        private int _countBillett2;

        private int _countCha;

        private int _countDesh;

        private int _countReLam;

        private Nullable<int> _idBilletColdLoadMode;

        private Nullable<int> _idBilletColdLoadMode2;

        private string _idBilletColdLoadMode2Txt;

        private string _idBilletColdLoadModeTxt;

        private Nullable<int> _idBilletColdLoadReason;

        private Nullable<int> _idBilletColdLoadReason2;

        private string _idBilletColdLoadReason2Txt;

        private string _idBilletColdLoadReasonTxt;

        private int _idRollingMillShift;

        private int _idRollingMillShiftOriginal;

        private Nullable<int> _idSystem;

        private string _infoColdMode;

        private string _infoColdMode2;

        private long _sequencia;

        private int _temperatureEnter;

        private int _temperatureExit;

        private DateTime _timeFurnaceBeginEntry;

        private DateTime _timeFurnaceEndEntry;

        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        /*partial void OnCreated();
        partial void OnCastingNumberChanging(string value);
        partial void OnCastingNumberChanged();
        partial void OnCountAnoChanging(int value);
        partial void OnCountAnoChanged();
        partial void OnCountBillettChanging(int value);
        partial void OnCountBillettChanged();
        partial void OnCountBillett2Changing(int value);
        partial void OnCountBillett2Changed();
        partial void OnCountChaChanging(int value);
        partial void OnCountChaChanged();
        partial void OnCountDeshChanging(int value);
        partial void OnCountDeshChanged();
        partial void OnCountReLamChanging(int value);
        partial void OnCountReLamChanged();
        partial void OnIDBilletColdLoadModeChanging(Nullable<int> value);
        partial void OnIDBilletColdLoadModeChanged();
        partial void OnIDBilletColdLoadMode2Changing(Nullable<int> value);
        partial void OnIDBilletColdLoadMode2Changed();
        partial void OnIDBilletColdLoadMode2TxtChanging(string value);
        partial void OnIDBilletColdLoadMode2TxtChanged();
        partial void OnIDBilletColdLoadModeTxtChanging(string value);
        partial void OnIDBilletColdLoadModeTxtChanged();
        partial void OnIDBilletColdLoadReasonChanging(Nullable<int> value);
        partial void OnIDBilletColdLoadReasonChanged();
        partial void OnIDBilletColdLoadReason2Changing(Nullable<int> value);
        partial void OnIDBilletColdLoadReason2Changed();
        partial void OnIDBilletColdLoadReason2TxtChanging(string value);
        partial void OnIDBilletColdLoadReason2TxtChanged();
        partial void OnIDBilletColdLoadReasonTxtChanging(string value);
        partial void OnIDBilletColdLoadReasonTxtChanged();
        partial void OnIDRollingMillShiftChanging(int value);
        partial void OnIDRollingMillShiftChanged();
        partial void OnIDRollingMillShiftOriginalChanging(int value);
        partial void OnIDRollingMillShiftOriginalChanged();
        partial void OnIDSystemChanging(Nullable<int> value);
        partial void OnIDSystemChanged();
        partial void OnInfoColdModeChanging(string value);
        partial void OnInfoColdModeChanged();
        partial void OnInfoColdMode2Changing(string value);
        partial void OnInfoColdMode2Changed();
        partial void OnSequenciaChanging(long value);
        partial void OnSequenciaChanged();
        partial void OnTemperatureEnterChanging(int value);
        partial void OnTemperatureEnterChanged();
        partial void OnTemperatureExitChanging(int value);
        partial void OnTemperatureExitChanged();
        partial void OnTimeFurnaceBeginEntryChanging(DateTime value);
        partial void OnTimeFurnaceBeginEntryChanged();
        partial void OnTimeFurnaceEndEntryChanging(DateTime value);
        partial void OnTimeFurnaceEndEntryChanged();
        */
        #endregion


        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBatchInternal"/> class.
        /// </summary>
        public ItemBatchInternal()
        {
            // this.OnCreated();
        }

        /// <summary>
        /// Gets or sets the 'CastingNumber' value.
        public string CastingNumber
        {
            get
            {
                return this._castingNumber;
            }
            set
            {
                if ((this._castingNumber != value))
                {
                    //this.OnCastingNumberChanging(value);
                    this._castingNumber = value;
                    //this.OnCastingNumberChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'CountAno' value.
        /// </summary>
        public int CountAno
        {
            get
            {
                return this._countAno;
            }
            set
            {
                if ((this._countAno != value))
                {
                    //this.OnCountAnoChanging(value);


                    this._countAno = value;

                    //this.OnCountAnoChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'CountBillett' value.
        /// </summary>

        public int CountBillett
        {
            get
            {
                return this._countBillett;
            }
            set
            {
                if ((this._countBillett != value))
                {
                    //this.OnCountBillettChanging(value);


                    this._countBillett = value;

                    //this.OnCountBillettChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'CountBillett2' value.
        /// </summary>

        public int CountBillett2
        {
            get
            {
                return this._countBillett2;
            }
            set
            {
                if ((this._countBillett2 != value))
                {
                    //this.OnCountBillett2Changing(value);


                    this._countBillett2 = value;

                    //this.OnCountBillett2Changed();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'CountCha' value.
        /// </summary>

        public int CountCha
        {
            get
            {
                return this._countCha;
            }
            set
            {
                if ((this._countCha != value))
                {
                    //this.OnCountChaChanging(value);


                    this._countCha = value;

                    //this.OnCountChaChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'CountDesh' value.
        /// </summary>

        public int CountDesh
        {
            get
            {
                return this._countDesh;
            }
            set
            {
                if ((this._countDesh != value))
                {
                    //this.OnCountDeshChanging(value);


                    this._countDesh = value;

                    //this.OnCountDeshChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'CountReLam' value.
        /// </summary>

        public int CountReLam
        {
            get
            {
                return this._countReLam;
            }
            set
            {
                if ((this._countReLam != value))
                {
                    //this.OnCountReLamChanging(value);


                    this._countReLam = value;

                    //this.OnCountReLamChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDBilletColdLoadMode' value.
        /// </summary>

        public Nullable<int> IDBilletColdLoadMode
        {
            get
            {
                return this._idBilletColdLoadMode;
            }
            set
            {
                if ((this._idBilletColdLoadMode != value))
                {
                    //this.OnIDBilletColdLoadModeChanging(value);


                    this._idBilletColdLoadMode = value;

                    //this.OnIDBilletColdLoadModeChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDBilletColdLoadMode2' value.
        /// </summary>

        public Nullable<int> IDBilletColdLoadMode2
        {
            get
            {
                return this._idBilletColdLoadMode2;
            }
            set
            {
                if ((this._idBilletColdLoadMode2 != value))
                {
                    //this.OnIDBilletColdLoadMode2Changing(value);


                    this._idBilletColdLoadMode2 = value;

                    //this.OnIDBilletColdLoadMode2Changed();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDBilletColdLoadMode2Txt' value.
        /// </summary>

        public string IDBilletColdLoadMode2Txt
        {
            get
            {
                return this._idBilletColdLoadMode2Txt;
            }
            set
            {
                if ((this._idBilletColdLoadMode2Txt != value))
                {
                    //this.OnIDBilletColdLoadMode2TxtChanging(value);


                    this._idBilletColdLoadMode2Txt = value;

                    //this.OnIDBilletColdLoadMode2TxtChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDBilletColdLoadModeTxt' value.
        /// </summary>

        public string IDBilletColdLoadModeTxt
        {
            get
            {
                return this._idBilletColdLoadModeTxt;
            }
            set
            {
                if ((this._idBilletColdLoadModeTxt != value))
                {
                    //this.OnIDBilletColdLoadModeTxtChanging(value);


                    this._idBilletColdLoadModeTxt = value;

                    //this.OnIDBilletColdLoadModeTxtChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDBilletColdLoadReason' value.
        /// </summary>

        public Nullable<int> IDBilletColdLoadReason
        {
            get
            {
                return this._idBilletColdLoadReason;
            }
            set
            {
                if ((this._idBilletColdLoadReason != value))
                {
                    //this.OnIDBilletColdLoadReasonChanging(value);


                    this._idBilletColdLoadReason = value;

                    //this.OnIDBilletColdLoadReasonChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDBilletColdLoadReason2' value.
        /// </summary>

        public Nullable<int> IDBilletColdLoadReason2
        {
            get
            {
                return this._idBilletColdLoadReason2;
            }
            set
            {
                if ((this._idBilletColdLoadReason2 != value))
                {
                    //this.OnIDBilletColdLoadReason2Changing(value);


                    this._idBilletColdLoadReason2 = value;

                    //this.OnIDBilletColdLoadReason2Changed();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDBilletColdLoadReason2Txt' value.
        /// </summary>

        public string IDBilletColdLoadReason2Txt
        {
            get
            {
                return this._idBilletColdLoadReason2Txt;
            }
            set
            {
                if ((this._idBilletColdLoadReason2Txt != value))
                {
                    //this.OnIDBilletColdLoadReason2TxtChanging(value);


                    this._idBilletColdLoadReason2Txt = value;

                    //this.OnIDBilletColdLoadReason2TxtChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDBilletColdLoadReasonTxt' value.
        /// </summary>

        public string IDBilletColdLoadReasonTxt
        {
            get
            {
                return this._idBilletColdLoadReasonTxt;
            }
            set
            {
                if ((this._idBilletColdLoadReasonTxt != value))
                {
                    //this.OnIDBilletColdLoadReasonTxtChanging(value);


                    this._idBilletColdLoadReasonTxt = value;

                    //this.OnIDBilletColdLoadReasonTxtChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDRollingMillShift' value.
        /// </summary>

        public int IDRollingMillShift
        {
            get
            {
                return this._idRollingMillShift;
            }
            set
            {
                if ((this._idRollingMillShift != value))
                {
                    //this.OnIDRollingMillShiftChanging(value);


                    this._idRollingMillShift = value;

                    //this.OnIDRollingMillShiftChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDRollingMillShiftOriginal' value.
        /// </summary>

        public int IDRollingMillShiftOriginal
        {
            get
            {
                return this._idRollingMillShiftOriginal;
            }
            set
            {
                if ((this._idRollingMillShiftOriginal != value))
                {
                    //this.OnIDRollingMillShiftOriginalChanging(value);


                    this._idRollingMillShiftOriginal = value;

                    //this.OnIDRollingMillShiftOriginalChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'IDSystem' value.
        /// </summary>
        public Nullable<int> IDSystem
        {
            get
            {
                return this._idSystem;
            }
            set
            {
                if ((this._idSystem != value))
                {
                    //this.OnIDSystemChanging(value);

                    this._idSystem = value;
                    //this.OnIDSystemChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'InfoColdMode' value.
        /// </summary>

        public string InfoColdMode
        {
            get
            {
                return this._infoColdMode;
            }
            set
            {
                if ((this._infoColdMode != value))
                {
                    //this.OnInfoColdModeChanging(value);


                    this._infoColdMode = value;

                    //this.OnInfoColdModeChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'InfoColdMode2' value.
        /// </summary>

        public string InfoColdMode2
        {
            get
            {
                return this._infoColdMode2;
            }
            set
            {
                if ((this._infoColdMode2 != value))
                {
                    //this.OnInfoColdMode2Changing(value);


                    this._infoColdMode2 = value;

                    //this.OnInfoColdMode2Changed();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'Sequencia' value.
        /// </summary>

        public long Sequencia
        {
            get
            {
                return this._sequencia;
            }
            set
            {
                if ((this._sequencia != value))
                {
                    //this.OnSequenciaChanging(value);

                    this._sequencia = value;
                    //this.OnSequenciaChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'TemperatureEnter' value.
        /// </summary>

        public int TemperatureEnter
        {
            get
            {
                return this._temperatureEnter;
            }
            set
            {
                if ((this._temperatureEnter != value))
                {
                    //this.OnTemperatureEnterChanging(value);


                    this._temperatureEnter = value;

                    //this.OnTemperatureEnterChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'TemperatureExit' value.
        /// </summary>

        public int TemperatureExit
        {
            get
            {
                return this._temperatureExit;
            }
            set
            {
                if ((this._temperatureExit != value))
                {
                    //this.OnTemperatureExitChanging(value);


                    this._temperatureExit = value;

                    //this.OnTemperatureExitChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'TimeFurnaceBeginEntry' value.
        /// </summary>

        public DateTime TimeFurnaceBeginEntry
        {
            get
            {
                return this._timeFurnaceBeginEntry;
            }
            set
            {
                if ((this._timeFurnaceBeginEntry != value))
                {
                    //this.OnTimeFurnaceBeginEntryChanging(value);


                    this._timeFurnaceBeginEntry = value;

                    //this.OnTimeFurnaceBeginEntryChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the 'TimeFurnaceEndEntry' value.
        /// </summary>

        public DateTime TimeFurnaceEndEntry
        {
            get
            {
                return this._timeFurnaceEndEntry;
            }
            set
            {
                if ((this._timeFurnaceEndEntry != value))
                {
                    //this.OnTimeFurnaceEndEntryChanging(value);


                    this._timeFurnaceEndEntry = value;

                    //this.OnTimeFurnaceEndEntryChanged();
                }
            }
        }
    }
}
