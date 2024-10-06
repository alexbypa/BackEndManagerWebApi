``` sql
alter procedure Feeds.sp_LSportsSnapshot
	@payload nvarchar(max) 
as
begin
	-- https://stm-snapshot.lsports.eu/PreMatch/GetEvents
	/*
	{
		"PackageId": 2251,
		"UserName": "a.chiodo@pixelo.it",
		"Password": "agsgse1dr5F94",
		"FromDate":1725947314,
		"ToDate":1725954514
	}
	*/
	set @payload  = '<?xml version="1.0" encoding="utf-8"?>
	<Feed>
		<Header>
			<Type>36</Type>
			<MsgGuid>f134e107-5363-4821-9750-89444f9842a9</MsgGuid>
			<ServerTimestamp>1725950993401</ServerTimestamp>
		</Header>
		<Body>
			<Events>
				<Event FixtureId="13699315">
					<Fixture LastUpdate="2024-09-10T06:43:50.372Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:15:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53542926" Name="atletico madrid (eduardo)" Position="1" />
							<Participant Id="53523437" Name="manchester city fc (vangogh)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="5400">
							<Score Position="1">1</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">0</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699316">
					<Fixture LastUpdate="2024-09-10T05:39:03.131Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53627462" Name="Fc Barcelona (popeye)" Position="1" />
							<Participant Id="53523437" Name="manchester city fc (vangogh)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699317">
					<Fixture LastUpdate="2024-09-10T05:39:05.617Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53520578" Name="Germany (leonardo)" Position="1" />
							<Participant Id="53730995" Name="England (logan)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699318">
					<Fixture LastUpdate="2024-09-10T06:47:48.848Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:15:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53534953" Name="Argentina (matrix)" Position="1" />
							<Participant Id="53730995" Name="England (logan)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="5400">
							<Score Position="1">3</Score>
							<Score Position="2">4</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">4</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699319">
					<Fixture LastUpdate="2024-09-10T05:39:07.476Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53534953" Name="Argentina (matrix)" Position="1" />
							<Participant Id="53522853" Name="France (obelix)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699320">
					<Fixture LastUpdate="2024-09-10T05:39:12.521Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53636286" Name="Paris Saint Germain (odin)" Position="1" />
							<Participant Id="53519517" Name="bayern munich (spiderman)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699321">
					<Fixture LastUpdate="2024-09-10T06:44:47.494Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:15:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53596414" Name="Italy (andrew)" Position="1" />
							<Participant Id="53520578" Name="Germany (leonardo)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="5400">
							<Score Position="1">1</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699328">
					<Fixture LastUpdate="2024-09-10T06:05:46.798Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T05:56:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52503497" Name="Manchester United (Labotryas)" Position="1" />
							<Participant Id="52910724" Name="liverpool (ecf_dava) esports" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">2</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699329">
					<Fixture LastUpdate="2024-09-10T06:09:44.778Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53733615" Name="Portugal (kravatskhelia)" Position="1" />
							<Participant Id="53565347" Name="Germany (koftovsky)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">1</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">0</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699330">
					<Fixture LastUpdate="2024-09-10T06:09:56.803Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52473681" Name="Italy (nikkitta)" Position="1" />
							<Participant Id="52616158" Name="Spain (lion)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">4</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699331">
					<Fixture LastUpdate="2024-09-10T06:05:56.319Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T05:56:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52401941" Name="Tottenham (Flewless_phoenix) (E)" Position="1" />
							<Participant Id="52404792" Name="Manchester City (KRaftVK) (E)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">2</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13673018">
					<Fixture LastUpdate="2024-09-06T13:22:45.491Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="69132" Name="E-Football | FIFA 23 - Amateur Daily League (E)" />
						<StartDate>2024-09-10T07:45:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53084873" Name="Sevilla (centurion)" Position="1" />
							<Participant Id="53595124" Name="West Ham (fear)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Markets>
						<Market Id="155" Name="Under/Over 1st Period - Away Team" MainLine="5.5">
							<Bets>
								<Bet Id="73707293913673018" Name="Under" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.77" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.251Z" SuspensionReason="14" />
								<Bet Id="1195081713673018" Name="Over" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.9" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.251Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="1" Name="1X2">
							<Bets>
								<Bet Id="97251521213673018" Name="1" Status="2" StartPrice="1.0" Price="2.01" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.282Z" SuspensionReason="14" />
								<Bet Id="21713539313673018" Name="X" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.282Z" SuspensionReason="14" />
								<Bet Id="175636814313673018" Name="2" Status="2" StartPrice="1.0" Price="2.08" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.282Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="64" Name="Asian Handicap 1st Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="75744859613673018" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.53" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.303Z" SuspensionReason="14" />
								<Bet Id="27530292413673018" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.43" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.303Z" SuspensionReason="14" />
								<Bet Id="15671095413673018" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.85" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.303Z" SuspensionReason="14" />
								<Bet Id="27181498713673018" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.81" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.303Z" SuspensionReason="14" />
								<Bet Id="15782717713673018" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.46" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.303Z" SuspensionReason="14" />
								<Bet Id="87478078713673018" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.45" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.303Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="2" Name="Under/Over" MainLine="23.0">
							<Bets>
								<Bet Id="122913592513673018" Name="Under" Line="23.0" BaseLine="23.0" Status="2" StartPrice="1.0" Price="1.84" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="167229871013673018" Name="Over" Line="24.0" BaseLine="24.0" Status="2" StartPrice="1.0" Price="2.22" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="95582809613673018" Name="Over" Line="23.5" BaseLine="23.5" Status="2" StartPrice="1.0" Price="1.99" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="179325823513673018" Name="Over" Line="22.5" BaseLine="22.5" Status="2" StartPrice="1.0" Price="1.68" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="122913593013673018" Name="Under" Line="23.5" BaseLine="23.5" Status="2" StartPrice="1.0" Price="1.69" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="122913622013673018" Name="Under" Line="24.0" BaseLine="24.0" Status="2" StartPrice="1.0" Price="1.55" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="19631320913673018" Name="Over" Line="23.0" BaseLine="23.0" Status="2" StartPrice="1.0" Price="1.82" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="122913602213673018" Name="Under" Line="22.0" BaseLine="22.0" Status="2" StartPrice="1.0" Price="2.26" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="138997370813673018" Name="Over" Line="22.0" BaseLine="22.0" Status="2" StartPrice="1.0" Price="1.54" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
								<Bet Id="122913602513673018" Name="Under" Line="22.5" BaseLine="22.5" Status="2" StartPrice="1.0" Price="2.01" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.309Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="3" Name="Asian Handicap" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="83822687413673018" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.2" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.271Z" SuspensionReason="14" />
								<Bet Id="213967851913673018" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.29" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.271Z" SuspensionReason="14" />
								<Bet Id="110062436413673018" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.8" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.271Z" SuspensionReason="14" />
								<Bet Id="56673685413673018" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.57" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.271Z" SuspensionReason="14" />
								<Bet Id="114190566913673018" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.271Z" SuspensionReason="14" />
								<Bet Id="111986177713673018" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.52" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.271Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="65" Name="Asian Handicap 2nd Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="213339246213673018" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="1" StartPrice="1.0" Price="2.45" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.372Z" />
								<Bet Id="156209703513673018" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="1" StartPrice="1.0" Price="1.43" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.372Z" />
								<Bet Id="197071554113673018" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="1" StartPrice="1.0" Price="2.53" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.372Z" />
								<Bet Id="137109405813673018" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="1" StartPrice="1.0" Price="1.46" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.372Z" />
								<Bet Id="137221028113673018" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="1" StartPrice="1.0" Price="1.85" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.372Z" />
								<Bet Id="156558497213673018" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="1" StartPrice="1.0" Price="1.81" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.372Z" />
							</Bets>
						</Market>
						<Market Id="5" Name="Odd/Even">
							<Bets>
								<Bet Id="20016158613673018" Name="Odd" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.288Z" SuspensionReason="14" />
								<Bet Id="15333573713673018" Name="Even" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.288Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="100" Name="Correct Score 2nd Period">
							<Bets>
								<Bet Id="164477976113673018" Name="5-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="106390061813673018" Name="4-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="178594226213673018" Name="6-6" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="166498273713673018" Name="4-5" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="19965534513673018" Name="7-6" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="134622562013673018" Name="6-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="136642859613673018" Name="7-5" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="7869582013673018" Name="5-7" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="9889879613673018" Name="4-6" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="148738812113673018" Name="5-6" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="138265773513673018" Name="6-5" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
								<Bet Id="108410359413673018" Name="5-5" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.366Z" />
							</Bets>
						</Market>
						<Market Id="7" Name="Double Chance">
							<Bets>
								<Bet Id="177800475113673018" Name="X2" Status="2" StartPrice="1.0" Price="1.75" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.297Z" SuspensionReason="14" />
								<Bet Id="55372563013673018" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.297Z" SuspensionReason="14" />
								<Bet Id="55372552813673018" Name="1X" Status="2" StartPrice="1.0" Price="1.7" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.297Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="101" Name="Under/Over - Home Team" MainLine="11.5">
							<Bets>
								<Bet Id="173436202513673018" Name="Under" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.83" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.306Z" SuspensionReason="14" />
								<Bet Id="116026463713673018" Name="Over" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.83" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.306Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="102" Name="Under/Over - Away Team" MainLine="11.5">
							<Bets>
								<Bet Id="112952917013673018" Name="Over" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.300Z" SuspensionReason="14" />
								<Bet Id="193908533013673018" Name="Under" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.79" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.300Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="9" Name="Correct Score 1st Period">
							<Bets>
								<Bet Id="115769094613673018" Name="5-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="26723049413673018" Name="4-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="12606799313673018" Name="7-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="129885344713673018" Name="4-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="117789392213673018" Name="6-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="143002990813673018" Name="4-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="144001594813673018" Name="7-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="157119240913673018" Name="5-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="156097547313673018" Name="5-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="158117844913673018" Name="6-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="1509450813673018" Name="6-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
								<Bet Id="510846813673018" Name="5-7" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.257Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="41" Name="1st Period Winner">
							<Bets>
								<Bet Id="63489322913673018" Name="2" Status="2" StartPrice="1.0" Price="2.15" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.294Z" SuspensionReason="14" />
								<Bet Id="63489323213673018" Name="1" Status="2" StartPrice="1.0" Price="2.1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.294Z" SuspensionReason="14" />
								<Bet Id="63489325513673018" Name="X" Status="2" StartPrice="1.0" Price="7.75" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.294Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="42" Name="2nd Period Winner">
							<Bets>
								<Bet Id="63489313613673018" Name="2" Status="1" StartPrice="1.0" Price="2.15" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.375Z" />
								<Bet Id="63489313313673018" Name="1" Status="1" StartPrice="1.0" Price="2.1" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.375Z" />
								<Bet Id="63489309413673018" Name="X" Status="1" StartPrice="1.0" Price="7.75" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.375Z" />
							</Bets>
						</Market>
						<Market Id="45" Name="Under/Over 2nd Period" MainLine="11.0">
							<Bets>
								<Bet Id="177434850313673018" Name="Over" Line="10.5" BaseLine="10.5" Status="1" StartPrice="1.0" Price="1.63" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.361Z" />
								<Bet Id="207539803713673018" Name="Under" Line="10.5" BaseLine="10.5" Status="1" StartPrice="1.0" Price="2.09" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.361Z" />
								<Bet Id="177434853913673018" Name="Over" Line="11.0" BaseLine="11.0" Status="1" StartPrice="1.0" Price="1.82" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.361Z" />
								<Bet Id="193423553613673018" Name="Under" Line="11.5" BaseLine="11.5" Status="1" StartPrice="1.0" Price="1.64" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.361Z" />
								<Bet Id="117472064913673018" Name="Under" Line="11.0" BaseLine="11.0" Status="1" StartPrice="1.0" Price="1.84" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.361Z" />
								<Bet Id="177434853613673018" Name="Over" Line="11.5" BaseLine="11.5" Status="1" StartPrice="1.0" Price="2.07" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.361Z" />
							</Bets>
						</Market>
						<Market Id="21" Name="Under/Over 1st Period" MainLine="11.0">
							<Bets>
								<Bet Id="67226026313673018" Name="Under" Line="11.0" BaseLine="11.0" Status="2" StartPrice="1.0" Price="1.84" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.280Z" SuspensionReason="14" />
								<Bet Id="121670729113673018" Name="Under" Line="10.5" BaseLine="10.5" Status="2" StartPrice="1.0" Price="2.09" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.280Z" SuspensionReason="14" />
								<Bet Id="107554479013673018" Name="Under" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.64" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.280Z" SuspensionReason="14" />
								<Bet Id="123407258313673018" Name="Over" Line="10.5" BaseLine="10.5" Status="2" StartPrice="1.0" Price="1.63" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.280Z" SuspensionReason="14" />
								<Bet Id="123407255513673018" Name="Over" Line="11.0" BaseLine="11.0" Status="2" StartPrice="1.0" Price="1.82" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.280Z" SuspensionReason="14" />
								<Bet Id="123407255013673018" Name="Over" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="2.07" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.280Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="456" Name="Double Chance 1st Period">
							<Bets>
								<Bet Id="106850051513673018" Name="X2" Status="2" StartPrice="1.0" Price="1.69" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.259Z" SuspensionReason="14" />
								<Bet Id="86827904613673018" Name="1X" Status="2" StartPrice="1.0" Price="1.65" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.259Z" SuspensionReason="14" />
								<Bet Id="86827907213673018" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.259Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="457" Name="Double Chance 2nd Period">
							<Bets>
								<Bet Id="138470605313673018" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.285Z" SuspensionReason="14" />
								<Bet Id="138470607913673018" Name="1X" Status="1" StartPrice="1.0" Price="1.65" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.368Z" />
								<Bet Id="97348165613673018" Name="X2" Status="1" StartPrice="1.0" Price="1.69" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.368Z" />
							</Bets>
						</Market>
						<Market Id="59" Name="Next Goal">
							<Bets>
								<Bet Id="199173624113673018" Name="No Goal" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="9" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.291Z" SuspensionReason="14" />
								<Bet Id="99205713713673018" Name="2" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="1.88" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.291Z" SuspensionReason="14" />
								<Bet Id="99205182413673018" Name="1" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.291Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="153" Name="Under/Over 1st Period - Home Team" MainLine="5.5">
							<Bets>
								<Bet Id="158773356713673018" Name="Over" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.262Z" SuspensionReason="14" />
								<Bet Id="143145210513673018" Name="Under" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.8" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.262Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="154" Name="Under/Over 2nd Period - Home Team" MainLine="5.5">
							<Bets>
								<Bet Id="34222716213673018" Name="Under" Line="5.5" BaseLine="5.5" Status="1" StartPrice="1.0" Price="1.8" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.370Z" />
								<Bet Id="145241101213673018" Name="Over" Line="5.5" BaseLine="5.5" Status="1" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-09T22:05:22.370Z" />
							</Bets>
						</Market>
					</Markets>
				</Event>
				<Event FixtureId="13699336">
					<Fixture LastUpdate="2024-09-10T06:29:13.620Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="38301" Name="E-Football | GT Leagues (E) | 12 Minutes" />
						<StartDate>2024-09-10T06:15:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52999635" Name="Barcelona FC (aibothard)" Position="1" />
							<Participant Id="53672804" Name="Athletic Bilbao (furious)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="720">
							<Score Position="1">2</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="300" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="600" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="600" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="720" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="1">
								<Value Position="1">1</Value>
								<Value Position="2">2</Value>
								<Incidents>
									<Incident Period="10" IncidentType="1" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="1" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="480" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Statistic>
							<Statistic Type="2">
								<Value Position="1">2</Value>
								<Value Position="2">3</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">37</Value>
								<Value Position="2">27</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">26</Value>
								<Value Position="2">28</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">1</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699337">
					<Fixture LastUpdate="2024-09-10T06:29:31.655Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="38301" Name="E-Football | GT Leagues (E) | 12 Minutes" />
						<StartDate>2024-09-10T06:15:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53543346" Name="real madrid (jack)" Position="1" />
							<Participant Id="53559425" Name="atletico madrid (lucas)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="720">
							<Score Position="1">4</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="660" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="1">
								<Value Position="1">2</Value>
								<Value Position="2">4</Value>
								<Incidents>
									<Incident Period="10" IncidentType="1" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="1" Seconds="300" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="480" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="600" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">4</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="600" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Statistic>
							<Statistic Type="2">
								<Value Position="1">4</Value>
								<Value Position="2">1</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">30</Value>
								<Value Position="2">42</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">17</Value>
								<Value Position="2">29</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">1</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13673022">
					<Fixture LastUpdate="2024-09-06T13:22:55.020Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="69132" Name="E-Football | FIFA 23 - Amateur Daily League (E)" />
						<StartDate>2024-09-10T06:50:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="52959520" Name="AC Milan (maestro)" Position="1" />
							<Participant Id="53595124" Name="West Ham (fear)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Markets>
						<Market Id="155" Name="Under/Over 1st Period - Away Team" MainLine="5.5">
							<Bets>
								<Bet Id="46506147413673022" Name="Over" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.75" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.521Z" SuspensionReason="14" />
								<Bet Id="9300384013673022" Name="Under" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.91" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.521Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="1" Name="1X2">
							<Bets>
								<Bet Id="118524062213673022" Name="X" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.570Z" SuspensionReason="14" />
								<Bet Id="161089987613673022" Name="2" Status="2" StartPrice="1.0" Price="2.08" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.570Z" SuspensionReason="14" />
								<Bet Id="120761534913673022" Name="1" Status="2" StartPrice="1.0" Price="2.01" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.570Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="64" Name="Asian Handicap 1st Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="196167934213673022" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.43" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.524Z" SuspensionReason="14" />
								<Bet Id="154392195413673022" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.47" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.524Z" SuspensionReason="14" />
								<Bet Id="150946054913673022" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.44" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.524Z" SuspensionReason="14" />
								<Bet Id="150597261213673022" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.81" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.524Z" SuspensionReason="14" />
								<Bet Id="199628455913673022" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.52" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.524Z" SuspensionReason="14" />
								<Bet Id="154280573113673022" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.85" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.524Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="2" Name="Under/Over" MainLine="23.0">
							<Bets>
								<Bet Id="198842251813673022" Name="Under" Line="22.5" BaseLine="22.5" Status="2" StartPrice="1.0" Price="2.01" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.582Z" SuspensionReason="14" />
								<Bet Id="101708268313673022" Name="Over" Line="24.0" BaseLine="24.0" Status="2" StartPrice="1.0" Price="2.22" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.582Z" SuspensionReason="14" />
								<Bet Id="146077316213673022" Name="Over" Line="22.5" BaseLine="22.5" Status="2" StartPrice="1.0" Price="1.68" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.582Z" SuspensionReason="14" />
								<Bet Id="8510780313673022" Name="Over" Line="23.5" BaseLine="23.5" Status="2" StartPrice="1.0" Price="1.99" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.582Z" SuspensionReason="14" />
								<Bet Id="198842242613673022" Name="Under" Line="23.0" BaseLine="23.0" Status="2" StartPrice="1.0" Price="1.84" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.582Z" SuspensionReason="14" />
								<Bet Id="84462269013673022" Name="Over" Line="23.0" BaseLine="23.0" Status="2" StartPrice="1.0" Price="1.82" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.582Z" SuspensionReason="14" />
								<Bet Id="198842245713673022" Name="Under" Line="24.0" BaseLine="24.0" Status="2" StartPrice="1.0" Price="1.55" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.582Z" SuspensionReason="14" />
								<Bet Id="198842242313673022" Name="Under" Line="23.5" BaseLine="23.5" Status="2" StartPrice="1.0" Price="1.69" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.582Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="3" Name="Asian Handicap" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="116306805013673022" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.52" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.552Z" SuspensionReason="14" />
								<Bet Id="52377681013673022" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.29" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.552Z" SuspensionReason="14" />
								<Bet Id="114383063713673022" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.8" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.552Z" SuspensionReason="14" />
								<Bet Id="124999357613673022" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.552Z" SuspensionReason="14" />
								<Bet Id="195491631513673022" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.2" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.552Z" SuspensionReason="14" />
								<Bet Id="133633119713673022" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.57" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.552Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="65" Name="Asian Handicap 2nd Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="104649390713673022" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.43" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.561Z" SuspensionReason="14" />
								<Bet Id="153777846113673022" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.47" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.561Z" SuspensionReason="14" />
								<Bet Id="108541579213673022" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.52" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.561Z" SuspensionReason="14" />
								<Bet Id="149871263613673022" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.44" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.561Z" SuspensionReason="14" />
								<Bet Id="153666223813673022" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.85" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.561Z" SuspensionReason="14" />
								<Bet Id="149522469913673022" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.81" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.561Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="5" Name="Odd/Even">
							<Bets>
								<Bet Id="127125815213673022" Name="Even" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.527Z" SuspensionReason="14" />
								<Bet Id="115920778513673022" Name="Odd" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.527Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="7" Name="Double Chance">
							<Bets>
								<Bet Id="171674766713673022" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.576Z" SuspensionReason="14" />
								<Bet Id="62759528013673022" Name="X2" Status="2" StartPrice="1.0" Price="1.75" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.576Z" SuspensionReason="14" />
								<Bet Id="171674770913673022" Name="1X" Status="2" StartPrice="1.0" Price="1.7" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.576Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="100" Name="Correct Score 2nd Period">
							<Bets>
								<Bet Id="175617046513673022" Name="7-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="99291586613673022" Name="6-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="111387539113673022" Name="4-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="47241152613673022" Name="5-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="201829249113673022" Name="4-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="213551230413673022" Name="7-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="173596748913673022" Name="6-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="213925201613673022" Name="6-7" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="57316807513673022" Name="6-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="69038788813673022" Name="5-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="71059086413673022" Name="4-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="109367241513673022" Name="5-7" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
								<Bet Id="203849546713673022" Name="5-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.567Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="101" Name="Under/Over - Home Team" MainLine="11.5">
							<Bets>
								<Bet Id="58693107013673022" Name="Over" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.83" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.559Z" SuspensionReason="14" />
								<Bet Id="109025916613673022" Name="Under" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.83" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.559Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="102" Name="Under/Over - Away Team" MainLine="11.5">
							<Bets>
								<Bet Id="65797095913673022" Name="Under" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.79" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.555Z" SuspensionReason="14" />
								<Bet Id="71812467513673022" Name="Over" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.555Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="9" Name="Correct Score 1st Period">
							<Bets>
								<Bet Id="185174413613673022" Name="6-7" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="211386616213673022" Name="5-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="42682269613673022" Name="7-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="203993863313673022" Name="6-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="80990424713673022" Name="4-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="68894472213673022" Name="6-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="40661972013673022" Name="4-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="83010722313673022" Name="7-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="87713921913673022" Name="6-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="54778222113673022" Name="5-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="101830172013673022" Name="5-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="197270366113673022" Name="4-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
								<Bet Id="61501719313673022" Name="5-7" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.539Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="41" Name="1st Period Winner">
							<Bets>
								<Bet Id="37341445013673022" Name="2" Status="2" StartPrice="1.0" Price="2.15" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.546Z" SuspensionReason="14" />
								<Bet Id="37341444713673022" Name="1" Status="2" StartPrice="1.0" Price="2.09" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.546Z" SuspensionReason="14" />
								<Bet Id="37341440813673022" Name="X" Status="2" StartPrice="1.0" Price="7.9" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.546Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="42" Name="2nd Period Winner">
							<Bets>
								<Bet Id="37341456913673022" Name="X" Status="2" StartPrice="1.0" Price="7.9" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.532Z" SuspensionReason="14" />
								<Bet Id="37341454613673022" Name="1" Status="2" StartPrice="1.0" Price="2.09" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.532Z" SuspensionReason="14" />
								<Bet Id="37341454313673022" Name="2" Status="2" StartPrice="1.0" Price="2.15" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.532Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="45" Name="Under/Over 2nd Period" MainLine="11.5">
							<Bets>
								<Bet Id="25150345913673022" Name="Over" Line="12.0" BaseLine="12.0" Status="2" StartPrice="1.0" Price="2.11" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.549Z" SuspensionReason="14" />
								<Bet Id="49677729813673022" Name="Under" Line="10.5" BaseLine="10.5" Status="2" StartPrice="1.0" Price="2.38" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.549Z" SuspensionReason="14" />
								<Bet Id="25150355613673022" Name="Over" Line="11.0" BaseLine="11.0" Status="2" StartPrice="1.0" Price="1.62" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.549Z" SuspensionReason="14" />
								<Bet Id="40390009013673022" Name="Under" Line="11.0" BaseLine="11.0" Status="2" StartPrice="1.0" Price="2.1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.549Z" SuspensionReason="14" />
								<Bet Id="35561479713673022" Name="Under" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.82" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.549Z" SuspensionReason="14" />
								<Bet Id="25150352813673022" Name="Over" Line="10.5" BaseLine="10.5" Status="2" StartPrice="1.0" Price="1.49" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.549Z" SuspensionReason="14" />
								<Bet Id="25150356113673022" Name="Over" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.84" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.549Z" SuspensionReason="14" />
								<Bet Id="118238682713673022" Name="Under" Line="12.0" BaseLine="12.0" Status="2" StartPrice="1.0" Price="1.61" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.549Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="21" Name="Under/Over 1st Period" MainLine="11.5">
							<Bets>
								<Bet Id="141350621113673022" Name="Over" Line="12.0" BaseLine="12.0" Status="2" StartPrice="1.0" Price="2.11" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.573Z" SuspensionReason="14" />
								<Bet Id="141350615013673022" Name="Over" Line="10.5" BaseLine="10.5" Status="2" StartPrice="1.0" Price="1.49" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.573Z" SuspensionReason="14" />
								<Bet Id="169071645513673022" Name="Under" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.82" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.573Z" SuspensionReason="14" />
								<Bet Id="198589845513673022" Name="Under" Line="12.0" BaseLine="12.0" Status="2" StartPrice="1.0" Price="1.61" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.573Z" SuspensionReason="14" />
								<Bet Id="128743192813673022" Name="Under" Line="11.0" BaseLine="11.0" Status="2" StartPrice="1.0" Price="2.1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.573Z" SuspensionReason="14" />
								<Bet Id="141350611413673022" Name="Over" Line="11.0" BaseLine="11.0" Status="2" StartPrice="1.0" Price="1.62" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.573Z" SuspensionReason="14" />
								<Bet Id="183187895613673022" Name="Under" Line="10.5" BaseLine="10.5" Status="2" StartPrice="1.0" Price="2.38" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.573Z" SuspensionReason="14" />
								<Bet Id="141350611713673022" Name="Over" Line="11.5" BaseLine="11.5" Status="2" StartPrice="1.0" Price="1.84" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.573Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="456" Name="Double Chance 1st Period">
							<Bets>
								<Bet Id="137198207313673022" Name="1X" Status="2" StartPrice="1.0" Price="1.66" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.518Z" SuspensionReason="14" />
								<Bet Id="137198209513673022" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.518Z" SuspensionReason="14" />
								<Bet Id="184968864213673022" Name="X2" Status="2" StartPrice="1.0" Price="1.69" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.518Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="457" Name="Double Chance 2nd Period">
							<Bets>
								<Bet Id="88100305213673022" Name="1X" Status="2" StartPrice="1.0" Price="1.66" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.543Z" SuspensionReason="14" />
								<Bet Id="197015541713673022" Name="X2" Status="2" StartPrice="1.0" Price="1.69" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.543Z" SuspensionReason="14" />
								<Bet Id="88100303013673022" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.543Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="59" Name="Next Goal">
							<Bets>
								<Bet Id="83636865413673022" Name="2" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="1.88" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.579Z" SuspensionReason="14" />
								<Bet Id="83636756513673022" Name="1" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.579Z" SuspensionReason="14" />
								<Bet Id="116395462213673022" Name="No Goal" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="9" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.579Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="153" Name="Under/Over 1st Period - Home Team" MainLine="5.5">
							<Bets>
								<Bet Id="65317474013673022" Name="Over" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.73" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.536Z" SuspensionReason="14" />
								<Bet Id="209754578213673022" Name="Under" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.95" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.536Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="154" Name="Under/Over 2nd Period - Home Team" MainLine="5.5">
							<Bets>
								<Bet Id="98629626113673022" Name="Under" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.95" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.564Z" SuspensionReason="14" />
								<Bet Id="99930035513673022" Name="Over" Line="5.5" BaseLine="5.5" Status="2" StartPrice="1.0" Price="1.73" ProviderBetId="145" LastUpdate="2024-09-08T00:06:14.564Z" SuspensionReason="14" />
							</Bets>
						</Market>
					</Markets>
				</Event>
				<Event FixtureId="13699343">
					<Fixture LastUpdate="2024-09-10T05:45:08.072Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:16:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727201" Name="Celta de Vigo (bastony)" Position="1" />
							<Participant Id="53735710" Name="Barcelona FC (holis)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="1255">
							<Score Position="1">4</Score>
							<Score Position="2">6</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">6</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">4</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13673040">
					<Fixture LastUpdate="2024-09-10T06:00:36.216Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="69132" Name="E-Football | FIFA 23 - Amateur Daily League (E)" />
						<StartDate>2024-09-10T05:50:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53009043" Name="Napoli (wizard)" Position="1" />
							<Participant Id="53595124" Name="West Ham (fear)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Markets>
						<Market Id="155" Name="Under/Over 1st Period - Away Team" MainLine="5.5">
							<Bets>
								<Bet Id="100005000613673040" Name="Over" Line="5.5" BaseLine="5.5" Status="3" StartPrice="1.0" Price="1.75" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="189590732013673040" Name="Under" Line="5.5" BaseLine="5.5" Status="3" StartPrice="1.0" Price="1.91" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
							</Bets>
						</Market>
						<Market Id="1" Name="1X2">
							<Bets>
								<Bet Id="36839375613673040" Name="2" Status="2" StartPrice="1.0" Price="2.08" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.922Z" SuspensionReason="14" />
								<Bet Id="193447769713673040" Name="1" Status="2" StartPrice="1.0" Price="2.01" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.922Z" SuspensionReason="14" />
								<Bet Id="45837827413673040" Name="X" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.922Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="64" Name="Asian Handicap 1st Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="2615929713673040" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="2.52" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="172256984013673040" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.81" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="171908190313673040" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.44" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="152807892613673040" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.47" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="21701859013673040" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="2.43" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="152919514913673040" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.85" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
							</Bets>
						</Market>
						<Market Id="2" Name="Under/Over" MainLine="23.0">
							<Bets>
								<Bet Id="136867239813673040" Name="Under" Line="23.0" BaseLine="23.0" Status="3" StartPrice="1.0" Price="1.84" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="186897787813673040" Name="Over" Line="23.0" BaseLine="23.0" Status="3" StartPrice="1.0" Price="1.82" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="136867249813673040" Name="Under" Line="22.5" BaseLine="22.5" Status="3" StartPrice="1.0" Price="2.01" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="36595913673040" Name="Over" Line="24.0" BaseLine="24.0" Status="3" StartPrice="1.0" Price="2.22" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="12059356613673040" Name="Over" Line="22.5" BaseLine="22.5" Status="3" StartPrice="1.0" Price="1.68" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="166647453113673040" Name="Over" Line="23.5" BaseLine="23.5" Status="3" StartPrice="1.0" Price="1.99" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="136867240313673040" Name="Under" Line="23.5" BaseLine="23.5" Status="3" StartPrice="1.0" Price="1.69" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="136867256113673040" Name="Under" Line="24.0" BaseLine="24.0" Status="3" StartPrice="1.0" Price="1.55" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
							</Bets>
						</Market>
						<Market Id="65" Name="Asian Handicap 2nd Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="118710764813673040" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.52" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.886Z" SuspensionReason="14" />
								<Bet Id="42879985513673040" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.81" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.886Z" SuspensionReason="14" />
								<Bet Id="31369582213673040" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.85" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.886Z" SuspensionReason="14" />
								<Bet Id="43228779213673040" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.44" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.886Z" SuspensionReason="14" />
								<Bet Id="31481204513673040" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.47" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.886Z" SuspensionReason="14" />
								<Bet Id="106977545713673040" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.43" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.886Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="3" Name="Asian Handicap" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="43186902313673040" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.8" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.909Z" SuspensionReason="14" />
								<Bet Id="44708149813673040" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.29" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.909Z" SuspensionReason="14" />
								<Bet Id="176414340113673040" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.2" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.909Z" SuspensionReason="14" />
								<Bet Id="96575653313673040" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.57" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.909Z" SuspensionReason="14" />
								<Bet Id="41263161013673040" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.52" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.909Z" SuspensionReason="14" />
								<Bet Id="162056824013673040" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.909Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="5" Name="Odd/Even">
							<Bets>
								<Bet Id="61695512913673040" Name="Odd" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.916Z" SuspensionReason="14" />
								<Bet Id="136862529213673040" Name="Even" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.916Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="100" Name="Correct Score 2nd Period">
							<Bets>
								<Bet Id="102164635313673040" Name="6-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:36:57.879Z" />
								<Bet Id="170723700213673040" Name="6-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="104184932913673040" Name="7-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="116280885413673040" Name="5-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="211052152913673040" Name="6-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="42347806313673040" Name="4-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="196935902813673040" Name="5-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:36:57.879Z" />
								<Bet Id="52423461213673040" Name="7-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="40327508713673040" Name="5-7" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:43.016Z" />
								<Bet Id="54443758813673040" Name="6-7" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:43.016Z" />
								<Bet Id="75952432713673040" Name="5-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="73932135113673040" Name="4-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:36:57.879Z" />
								<Bet Id="198956200413673040" Name="4-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
							</Bets>
						</Market>
						<Market Id="7" Name="Double Chance">
							<Bets>
								<Bet Id="158188798913673040" Name="1X" Status="2" StartPrice="1.0" Price="1.7" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.878Z" SuspensionReason="14" />
								<Bet Id="99279467613673040" Name="X2" Status="2" StartPrice="1.0" Price="1.75" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.878Z" SuspensionReason="14" />
								<Bet Id="158188807913673040" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.878Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="101" Name="Under/Over - Home Team" MainLine="11.5">
							<Bets>
								<Bet Id="110497913413673040" Name="Over" Line="11.5" BaseLine="11.5" Status="3" StartPrice="1.0" Price="1.83" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="174773909413673040" Name="Under" Line="11.5" BaseLine="11.5" Status="3" StartPrice="1.0" Price="1.83" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
							</Bets>
						</Market>
						<Market Id="9" Name="Correct Score 1st Period">
							<Bets>
								<Bet Id="149331518013673040" Name="5-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:21:00.080Z" />
								<Bet Id="123556817513673040" Name="5-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:21:00.080Z" />
								<Bet Id="7276876113673040" Name="5-7" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:21:00.080Z" />
								<Bet Id="18935326513673040" Name="4-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:16:45.080Z" />
								<Bet Id="147311220413673040" Name="6-7" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="165905567813673040" Name="6-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="137673067613673040" Name="4-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:16:45.080Z" />
								<Bet Id="9297173713673040" Name="6-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:12.178Z" />
								<Bet Id="135215267913673040" Name="4-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:16:45.080Z" />
								<Bet Id="125577115113673040" Name="6-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="163885270213673040" Name="5-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:21:00.080Z" />
								<Bet Id="4819076413673040" Name="7-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="151789317713673040" Name="7-5" Status="3" StartPrice="1.0" Price="10" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
							</Bets>
						</Market>
						<Market Id="102" Name="Under/Over - Away Team" MainLine="11.5">
							<Bets>
								<Bet Id="90019435513673040" Name="Over" Line="11.5" BaseLine="11.5" Status="3" StartPrice="1.0" Price="1.87" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="192570826113673040" Name="Under" Line="11.5" BaseLine="11.5" Status="3" StartPrice="1.0" Price="1.79" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
							</Bets>
						</Market>
						<Market Id="41" Name="1st Period Winner">
							<Bets>
								<Bet Id="213590659013673040" Name="2" Status="3" StartPrice="1.0" Price="2.15" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="213590650013673040" Name="X" Status="3" StartPrice="1.0" Price="7.9" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="213590658913673040" Name="1" Status="3" StartPrice="1.0" Price="2.09" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
							</Bets>
						</Market>
						<Market Id="42" Name="2nd Period Winner">
							<Bets>
								<Bet Id="213590662113673040" Name="2" Status="2" StartPrice="1.0" Price="2.15" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.919Z" SuspensionReason="14" />
								<Bet Id="213590672713673040" Name="X" Status="2" StartPrice="1.0" Price="7.9" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.919Z" SuspensionReason="14" />
								<Bet Id="213590662213673040" Name="1" Status="2" StartPrice="1.0" Price="2.09" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.919Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="45" Name="Under/Over 2nd Period" MainLine="11.5">
							<Bets>
								<Bet Id="170251383613673040" Name="Over" Line="10.5" BaseLine="10.5" Status="3" StartPrice="1.0" Price="1.49" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="73522924713673040" Name="Under" Line="12.0" BaseLine="12.0" Status="3" StartPrice="1.0" Price="1.61" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="47310722113673040" Name="Under" Line="11.5" BaseLine="11.5" Status="3" StartPrice="1.0" Price="1.82" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="28640766613673040" Name="Under" Line="11.0" BaseLine="11.0" Status="3" StartPrice="1.0" Price="2.1" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="61426972213673040" Name="Under" Line="10.5" BaseLine="10.5" Status="3" StartPrice="1.0" Price="2.38" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:38:27.578Z" />
								<Bet Id="170251386913673040" Name="Over" Line="11.5" BaseLine="11.5" Status="3" StartPrice="1.0" Price="1.84" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="170251387213673040" Name="Over" Line="11.0" BaseLine="11.0" Status="3" StartPrice="1.0" Price="1.62" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
								<Bet Id="170251390713673040" Name="Over" Line="12.0" BaseLine="12.0" Status="3" StartPrice="1.0" Price="2.11" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:39:57.859Z" />
							</Bets>
						</Market>
						<Market Id="21" Name="Under/Over 1st Period" MainLine="11.5">
							<Bets>
								<Bet Id="71063364613673040" Name="Over" Line="11.0" BaseLine="11.0" Status="3" StartPrice="1.0" Price="1.62" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="68026690913673040" Name="Under" Line="11.5" BaseLine="11.5" Status="3" StartPrice="1.0" Price="1.82" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="53910440813673040" Name="Under" Line="10.5" BaseLine="10.5" Status="3" StartPrice="1.0" Price="2.38" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:12.178Z" />
								<Bet Id="71063361813673040" Name="Over" Line="10.5" BaseLine="10.5" Status="3" StartPrice="1.0" Price="1.49" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:12.178Z" />
								<Bet Id="71063365113673040" Name="Over" Line="11.5" BaseLine="11.5" Status="3" StartPrice="1.0" Price="1.84" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="108355143613673040" Name="Under" Line="11.0" BaseLine="11.0" Status="3" StartPrice="1.0" Price="2.1" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="71063368113673040" Name="Over" Line="12.0" BaseLine="12.0" Status="3" StartPrice="1.0" Price="2.11" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="50273548113673040" Name="Under" Line="12.0" BaseLine="12.0" Status="3" StartPrice="1.0" Price="1.61" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
							</Bets>
						</Market>
						<Market Id="456" Name="Double Chance 1st Period">
							<Bets>
								<Bet Id="34700847113673040" Name="1X" Status="3" StartPrice="1.0" Price="1.66" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="75823284213673040" Name="X2" Status="3" StartPrice="1.0" Price="1.69" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
								<Bet Id="34700844513673040" Name="12" Status="3" StartPrice="1.0" Price="1" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:24:33.350Z" />
							</Bets>
						</Market>
						<Market Id="457" Name="Double Chance 2nd Period">
							<Bets>
								<Bet Id="169497370013673040" Name="1X" Status="2" StartPrice="1.0" Price="1.66" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.901Z" SuspensionReason="14" />
								<Bet Id="169497372613673040" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.901Z" SuspensionReason="14" />
								<Bet Id="149475228313673040" Name="X2" Status="2" StartPrice="1.0" Price="1.69" ProviderBetId="145" LastUpdate="2024-09-08T00:06:15.901Z" SuspensionReason="14" />
							</Bets>
						</Market>
						<Market Id="59" Name="Next Goal">
							<Bets>
								<Bet Id="209035143813673040" Name="No Goal" Line="1.0" BaseLine="1.0" Status="3" StartPrice="1.0" Price="9" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:05:37.981Z" />
								<Bet Id="152662152513673040" Name="1" Line="1.0" BaseLine="1.0" Status="3" StartPrice="1.0" Price="1.86" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:05:37.981Z" />
								<Bet Id="152661825813673040" Name="2" Line="1.0" BaseLine="1.0" Status="3" StartPrice="1.0" Price="1.88" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:05:37.981Z" />
							</Bets>
						</Market>
						<Market Id="153" Name="Under/Over 1st Period - Home Team" MainLine="5.5">
							<Bets>
								<Bet Id="171913454013673040" Name="Over" Line="5.5" BaseLine="5.5" Status="3" StartPrice="1.0" Price="1.73" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:21:00.080Z" />
								<Bet Id="170468081013673040" Name="Under" Line="5.5" BaseLine="5.5" Status="3" StartPrice="1.0" Price="1.95" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:21:00.080Z" />
							</Bets>
						</Market>
						<Market Id="154" Name="Under/Over 2nd Period - Home Team" MainLine="5.5">
							<Bets>
								<Bet Id="81660721913673040" Name="Under" Line="5.5" BaseLine="5.5" Status="3" StartPrice="1.0" Price="1.95" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:47:22.179Z" />
								<Bet Id="46431182313673040" Name="Over" Line="5.5" BaseLine="5.5" Status="3" StartPrice="1.0" Price="1.73" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:47:22.179Z" />
							</Bets>
						</Market>
					</Markets>
				</Event>
				<Event FixtureId="13699358">
					<Fixture LastUpdate="2024-09-10T06:12:24.609Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="79316" Name="E-Football | Valkyrie Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T05:50:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53742269" Name="Spain (valeria)" Position="1" />
							<Participant Id="53738576" Name="England (mia)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="2400">
							<Score Position="1">2</Score>
							<Score Position="2">5</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">5</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699359">
					<Fixture LastUpdate="2024-09-10T05:50:16.333Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727204" Name="Osasuna (henry)" Position="1" />
							<Participant Id="53727201" Name="Celta de Vigo (bastony)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699360">
					<Fixture LastUpdate="2024-09-10T05:50:19.765Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:58:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727201" Name="Celta de Vigo (bastony)" Position="1" />
							<Participant Id="53727745" Name="Getafe Cf (jacob17)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699361">
					<Fixture LastUpdate="2024-09-10T05:50:20.510Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:44:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53724379" Name="Girona (pedro)" Position="1" />
							<Participant Id="53727201" Name="Celta de Vigo (bastony)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699362">
					<Fixture LastUpdate="2024-09-10T05:50:20.704Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T07:12:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727204" Name="Osasuna (henry)" Position="1" />
							<Participant Id="53727745" Name="Getafe Cf (jacob17)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699363">
					<Fixture LastUpdate="2024-09-10T06:04:52.690Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T05:50:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53695370" Name="Paris Saint Germain (lava)" Position="1" />
							<Participant Id="53697209" Name="Bayern (Mj) Esports" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">0</Score>
							<Score Position="2">4</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">4</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="480" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">4</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="2">
								<Value Position="1">0</Value>
								<Value Position="2">4</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">14</Value>
								<Value Position="2">19</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">12</Value>
								<Value Position="2">22</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">1</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699365">
					<Fixture LastUpdate="2024-09-10T06:17:46.742Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:08:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52910724" Name="liverpool (ecf_dava) esports" Position="1" />
							<Participant Id="52401941" Name="Tottenham (Flewless_phoenix) (E)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">4</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699366">
					<Fixture LastUpdate="2024-09-10T06:21:41.713Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:12:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53565347" Name="Germany (koftovsky)" Position="1" />
							<Participant Id="52473681" Name="Italy (nikkitta)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">2</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699367">
					<Fixture LastUpdate="2024-09-10T06:21:53.735Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:12:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52408970" Name="England (Arcos) (E)" Position="1" />
							<Participant Id="53733615" Name="Portugal (kravatskhelia)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">4</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">3</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699368">
					<Fixture LastUpdate="2024-09-10T06:18:01.782Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:08:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52404792" Name="Manchester City (KRaftVK) (E)" Position="1" />
							<Participant Id="52449764" Name="Arsenal (Sane4ek8)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">1</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">0</Score>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699370">
					<Fixture LastUpdate="2024-09-10T06:13:21.712Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="79316" Name="E-Football | Valkyrie Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T05:52:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53742268" Name="USA (ellen)" Position="1" />
							<Participant Id="53722302" Name="Portugal (july)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="2400">
							<Score Position="1">2</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699387">
					<Fixture LastUpdate="2024-09-10T05:55:27.561Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:14:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727204" Name="Osasuna (henry)" Position="1" />
							<Participant Id="53724379" Name="Girona (pedro)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699392">
					<Fixture LastUpdate="2024-09-10T06:10:26.860Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53736451" Name="Spain (hound)" Position="1" />
							<Participant Id="53706294" Name="France (chipper)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">2</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="-1" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">0</Score>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="2">
								<Value Position="1">2</Value>
								<Value Position="2">1</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">21</Value>
								<Value Position="2">18</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">19</Value>
								<Value Position="2">10</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699394">
					<Fixture LastUpdate="2024-09-10T06:13:24.717Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="54289" Name="E-Football | FIFA 23 Volta Daily League (E) | 2x3 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53156503" Name="Real Madrid (frogyy)" Position="1" />
							<Participant Id="53090439" Name="Barcelona FC (ricky)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="0">
							<Score Position="1">2</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="0" ParticipantPosition="2">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="0" ParticipantPosition="1">
										<Score Position="1">2</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">1</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">0</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">0</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699397">
					<Fixture LastUpdate="2024-09-10T06:27:31.111Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="196" Name="China" />
						<League Id="76997" Name="China League One W (old China Championship W)" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53020411" Name="Guangxi Pingguo Banong W" Position="1" />
							<Participant Id="53742055" Name="Hebei Junlebao W" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699401">
					<Fixture LastUpdate="2024-09-10T06:29:47.185Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:20:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52503497" Name="Manchester United (Labotryas)" Position="1" />
							<Participant Id="52401941" Name="Tottenham (Flewless_phoenix) (E)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">3</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="-1" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699402">
					<Fixture LastUpdate="2024-09-10T06:29:25.642Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:20:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52910724" Name="liverpool (ecf_dava) esports" Position="1" />
							<Participant Id="52449764" Name="Arsenal (Sane4ek8)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">2</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699404">
					<Fixture LastUpdate="2024-09-10T06:01:36.651Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="196" Name="China" />
						<League Id="76997" Name="China League One W (old China Championship W)" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53564815" Name="Liaoning Shenbei Hefeng W" Position="1" />
							<Participant Id="53674825" Name="Dalian W" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699405">
					<Fixture LastUpdate="2024-09-10T06:29:56.203Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="65306" Name="USSR 3X3" />
						<StartDate>2024-09-10T06:05:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53521216" Name="Belarus (3F3)" Position="1" />
							<Participant Id="53531101" Name="Kazakhstan (3X3)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="5400">
							<Score Position="1">7</Score>
							<Score Position="2">8</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">7</Score>
								<Score Position="2">8</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">3</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="0" ParticipantPosition="1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="300" ParticipantPosition="1">
										<Score Position="1">3</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="420" ParticipantPosition="1">
										<Score Position="1">4</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="480" ParticipantPosition="2">
										<Score Position="1">4</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="5400" ParticipantPosition="2">
										<Score Position="1">4</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">5</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">7</Score>
										<Score Position="2">7</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">6</Score>
										<Score Position="2">7</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">4</Score>
										<Score Position="2">4</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">5</Score>
										<Score Position="2">5</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">5</Score>
										<Score Position="2">4</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">6</Score>
										<Score Position="2">5</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">6</Score>
										<Score Position="2">6</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="5400" ParticipantPosition="2">
										<Score Position="1">7</Score>
										<Score Position="2">8</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699408">
					<Fixture LastUpdate="2024-09-10T06:00:45.031Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:28:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53724379" Name="Girona (pedro)" Position="1" />
							<Participant Id="53727745" Name="Getafe Cf (jacob17)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699409">
					<Fixture LastUpdate="2024-09-10T06:00:45.198Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:42:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53735710" Name="Barcelona FC (holis)" Position="1" />
							<Participant Id="53727745" Name="Getafe Cf (jacob17)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699414">
					<Fixture LastUpdate="2024-09-10T06:43:50.386Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="38301" Name="E-Football | GT Leagues (E) | 12 Minutes" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52999635" Name="Barcelona FC (aibothard)" Position="1" />
							<Participant Id="53559425" Name="atletico madrid (lucas)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="720">
							<Score Position="1">1</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">3</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="480" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="720" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="1">
								<Value Position="1">1</Value>
								<Value Position="2">4</Value>
								<Incidents>
									<Incident Period="20" IncidentType="1" Seconds="480" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="480" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="540" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="540" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="1" Seconds="660" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">4</Score>
									</Incident>
								</Incidents>
							</Statistic>
							<Statistic Type="2">
								<Value Position="1">1</Value>
								<Value Position="2">3</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">27</Value>
								<Value Position="2">27</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">17</Value>
								<Value Position="2">31</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699415">
					<Fixture LastUpdate="2024-09-10T06:43:38.347Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="38301" Name="E-Football | GT Leagues (E) | 12 Minutes" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53543346" Name="real madrid (jack)" Position="1" />
							<Participant Id="53694801" Name="Girona (david)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="720">
							<Score Position="1">3</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="480" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="600" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="660" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="1">
								<Value Position="1">2</Value>
								<Value Position="2">0</Value>
								<Incidents>
									<Incident Period="10" IncidentType="1" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="1" Seconds="180" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Statistic>
							<Statistic Type="2">
								<Value Position="1">3</Value>
								<Value Position="2">1</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">34</Value>
								<Value Position="2">26</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">25</Value>
								<Value Position="2">19</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699416">
					<Fixture LastUpdate="2024-09-10T06:02:00.535Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="38301" Name="E-Football | GT Leagues (E) | 12 Minutes" />
						<StartDate>2024-09-10T07:00:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53694801" Name="Girona (david)" Position="1" />
							<Participant Id="53559425" Name="atletico madrid (lucas)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699417">
					<Fixture LastUpdate="2024-09-10T06:02:00.671Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="38301" Name="E-Football | GT Leagues (E) | 12 Minutes" />
						<StartDate>2024-09-10T07:00:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53543346" Name="real madrid (jack)" Position="1" />
							<Participant Id="53672804" Name="Athletic Bilbao (furious)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699421">
					<Fixture LastUpdate="2024-09-10T06:34:00.190Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:24:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52616158" Name="Spain (lion)" Position="1" />
							<Participant Id="53565347" Name="Germany (koftovsky)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">2</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699422">
					<Fixture LastUpdate="2024-09-10T06:34:00.191Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:24:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52473681" Name="Italy (nikkitta)" Position="1" />
							<Participant Id="52408970" Name="England (Arcos) (E)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">2</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699425">
					<Fixture LastUpdate="2024-09-10T06:04:12.110Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="79316" Name="E-Football | Valkyrie Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:04:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53741446" Name="France (tracy)" Position="1" />
							<Participant Id="53738576" Name="England (mia)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699428">
					<Fixture LastUpdate="2024-09-10T06:06:21.727Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="79316" Name="E-Football | Valkyrie Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:06:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53742269" Name="Spain (valeria)" Position="1" />
							<Participant Id="53722302" Name="Portugal (july)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699433">
					<Fixture LastUpdate="2024-09-10T06:20:32.573Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:07:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53700209" Name="Real Madrid (bullfrog)" Position="1" />
							<Participant Id="53708238" Name="Manchester City (radical)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">1</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="2">
								<Value Position="1">1</Value>
								<Value Position="2">3</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">27</Value>
								<Value Position="2">20</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">20</Value>
								<Value Position="2">26</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699434">
					<Fixture LastUpdate="2024-09-10T06:42:02.154Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:32:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52449764" Name="Arsenal (Sane4ek8)" Position="1" />
							<Participant Id="52503497" Name="Manchester United (Labotryas)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">4</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699435">
					<Fixture LastUpdate="2024-09-10T06:42:02.153Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:32:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52404792" Name="Manchester City (KRaftVK) (E)" Position="1" />
							<Participant Id="52910724" Name="liverpool (ecf_dava) esports" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">1</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699438">
					<Fixture LastUpdate="2024-09-10T06:08:37.101Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:45:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53519517" Name="bayern munich (spiderman)" Position="1" />
							<Participant Id="53542926" Name="atletico madrid (eduardo)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699439">
					<Fixture LastUpdate="2024-09-10T06:08:37.809Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:45:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53636286" Name="Paris Saint Germain (odin)" Position="1" />
							<Participant Id="53523437" Name="manchester city fc (vangogh)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699440">
					<Fixture LastUpdate="2024-09-10T06:08:38.084Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:00:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53519517" Name="bayern munich (spiderman)" Position="1" />
							<Participant Id="53627462" Name="Fc Barcelona (popeye)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699441">
					<Fixture LastUpdate="2024-09-10T06:09:20.729Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:00:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53730995" Name="England (logan)" Position="1" />
							<Participant Id="53596414" Name="Italy (andrew)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699442">
					<Fixture LastUpdate="2024-09-10T06:09:21.065Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:45:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53520578" Name="Germany (leonardo)" Position="1" />
							<Participant Id="53534953" Name="Argentina (matrix)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699444">
					<Fixture LastUpdate="2024-09-10T06:10:10.221Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:00:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53636286" Name="Paris Saint Germain (odin)" Position="1" />
							<Participant Id="53542926" Name="atletico madrid (eduardo)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699447">
					<Fixture LastUpdate="2024-09-10T06:10:58.128Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:56:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727204" Name="Osasuna (henry)" Position="1" />
							<Participant Id="53735710" Name="Barcelona FC (holis)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699448">
					<Fixture LastUpdate="2024-09-10T06:10:58.516Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T07:10:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53724379" Name="Girona (pedro)" Position="1" />
							<Participant Id="53735710" Name="Barcelona FC (holis)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699449">
					<Fixture LastUpdate="2024-09-10T06:24:45.579Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:11:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53725203" Name="England (comet)" Position="1" />
							<Participant Id="53699772" Name="Portugal (fame)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">1</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="2">
								<Value Position="1">1</Value>
								<Value Position="2">2</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">17</Value>
								<Value Position="2">10</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">14</Value>
								<Value Position="2">12</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13690328">
					<Fixture LastUpdate="2024-09-10T06:42:19.855Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="187" Name="Belarus" />
						<League Id="64093" Name="Regional League A" />
						<StartDate>2024-09-10T06:40:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53548805" Name="Rogachev" Position="1" />
							<Participant Id="53548721" Name="Borisov" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Markets>
						<Market Id="155" Name="Under/Over 1st Period - Away Team" MainLine="2.0">
							<Bets>
								<Bet Id="87410802613690328" Name="Over" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="1.92" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.451Z" SuspensionReason="10" />
								<Bet Id="138890190013690328" Name="Under" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="1.88" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.451Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="1" Name="1X2">
							<Bets>
								<Bet Id="145094828813690328" Name="X" Status="2" StartPrice="1.0" Price="6.86" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.409Z" SuspensionReason="10" />
								<Bet Id="123588042913690328" Name="1" Status="2" StartPrice="1.0" Price="2.32" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.409Z" SuspensionReason="10" />
								<Bet Id="83259590213690328" Name="2" Status="2" StartPrice="1.0" Price="2.05" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.409Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="2" Name="Under/Over" MainLine="8.5">
							<Bets>
								<Bet Id="83294314313690328" Name="Over" Line="7.5" BaseLine="7.5" Status="2" StartPrice="1.0" Price="1.485" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.442Z" SuspensionReason="10" />
								<Bet Id="83294337013690328" Name="Over" Line="8.5" BaseLine="8.5" Status="2" StartPrice="1.0" Price="1.885" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.442Z" SuspensionReason="10" />
								<Bet Id="176599675013690328" Name="Under" Line="8.5" BaseLine="8.5" Status="2" StartPrice="1.0" Price="1.915" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.442Z" SuspensionReason="10" />
								<Bet Id="83294337313690328" Name="Over" Line="8.0" BaseLine="8.0" Status="2" StartPrice="1.0" Price="1.63" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.442Z" SuspensionReason="10" />
								<Bet Id="198797115513690328" Name="Under" Line="7.5" BaseLine="7.5" Status="2" StartPrice="1.0" Price="2.64" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.442Z" SuspensionReason="10" />
								<Bet Id="176945565913690328" Name="Under" Line="8.0" BaseLine="8.0" Status="2" StartPrice="1.0" Price="2.28" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.442Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="64" Name="Asian Handicap 1st Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="176295778013690328" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="3.81" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.416Z" SuspensionReason="10" />
								<Bet Id="61394627113690328" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.74" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.416Z" SuspensionReason="10" />
								<Bet Id="61743420813690328" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.24" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.416Z" SuspensionReason="10" />
								<Bet Id="65077939013690328" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="2.09" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.416Z" SuspensionReason="10" />
								<Bet Id="65189561313690328" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.37" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.416Z" SuspensionReason="10" />
								<Bet Id="179756299713690328" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="3.104" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.416Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="65" Name="Asian Handicap 2nd Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="11741411213690328" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.79" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.418Z" SuspensionReason="10" />
								<Bet Id="7597657313690328" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.418Z" SuspensionReason="10" />
								<Bet Id="195497431713690328" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="3.32" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.418Z" SuspensionReason="10" />
								<Bet Id="11392617513690328" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.26" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.418Z" SuspensionReason="10" />
								<Bet Id="199389620213690328" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="3.1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.418Z" SuspensionReason="10" />
								<Bet Id="7486035013690328" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.3" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.418Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="3" Name="Asian Handicap" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="31893452013690328" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.52" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.413Z" SuspensionReason="10" />
								<Bet Id="81779989313690328" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.98" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.413Z" SuspensionReason="10" />
								<Bet Id="169588895313690328" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.395" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.413Z" SuspensionReason="10" />
								<Bet Id="1275357013690328" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.79" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.413Z" SuspensionReason="10" />
								<Bet Id="33817193313690328" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="2.025" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.413Z" SuspensionReason="10" />
								<Bet Id="92928827213690328" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.53" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.413Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="6" Name="Correct Score">
							<Bets>
								<Bet Id="174671115813690328" Name="3-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="138545672413690328" Name="3-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="214497161113690328" Name="3-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="124267008213690328" Name="6-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="138383258313690328" Name="5-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="120388827113690328" Name="4-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="36219567013690328" Name="4-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="148621327313690328" Name="6-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="18062721713690328" Name="3-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="32178971813690328" Name="2-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="124429422313690328" Name="2-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="178711711013690328" Name="5-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="22103316913690328" Name="5-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="188787365913690328" Name="2-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="160717279813690328" Name="4-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="98217219713690328" Name="3-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="152499508413690328" Name="4-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="67964421913690328" Name="6-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="192827961113690328" Name="4-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
								<Bet Id="134505077213690328" Name="5-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.421Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="7" Name="Double Chance">
							<Bets>
								<Bet Id="178610618613690328" Name="X2" Status="2" StartPrice="1.0" Price="1.58" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.428Z" SuspensionReason="10" />
								<Bet Id="137488178913690328" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.428Z" SuspensionReason="10" />
								<Bet Id="137488175113690328" Name="1X" Status="2" StartPrice="1.0" Price="1.736" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.428Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="100" Name="Correct Score 2nd Period">
							<Bets>
								<Bet Id="69719686413690328" Name="2-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="44539957413690328" Name="3-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="110048139113690328" Name="2-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="99972484213690328" Name="1-0" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="59644031513690328" Name="1-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="46560255013690328" Name="2-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="160819898813690328" Name="3-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="86888707713690328" Name="2-0" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="132587398613690328" Name="1-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="154417187013690328" Name="4-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="84868410113690328" Name="3-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="201148351513690328" Name="3-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="213244304013690328" Name="1-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="214232128013690328" Name="0-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="114088734313690328" Name="4-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="203168649113690328" Name="2-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="56635909913690328" Name="1-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="158799601213690328" Name="4-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="57623733913690328" Name="0-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
								<Bet Id="97952186613690328" Name="0-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.426Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="101" Name="Under/Over - Home Team" MainLine="4.0">
							<Bets>
								<Bet Id="124607676113690328" Name="Under" Line="4.0" BaseLine="4.0" Status="2" StartPrice="1.0" Price="1.984" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.447Z" SuspensionReason="10" />
								<Bet Id="101222555713690328" Name="Over" Line="4.0" BaseLine="4.0" Status="2" StartPrice="1.0" Price="1.825" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.447Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="102" Name="Under/Over - Away Team" MainLine="4.5">
							<Bets>
								<Bet Id="89097414513690328" Name="Over" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="2.075" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.445Z" SuspensionReason="10" />
								<Bet Id="178825650913690328" Name="Under" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.752" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.445Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="9" Name="Correct Score 1st Period">
							<Bets>
								<Bet Id="149027241413690328" Name="1-0" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="189355694113690328" Name="1-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="179280039213690328" Name="2-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="95628593913690328" Name="3-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="94582538613690328" Name="4-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="151047539013690328" Name="0-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="134910991313690328" Name="4-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="32747300013690328" Name="1-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="22671645113690328" Name="2-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="47909605413690328" Name="1-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="20651347513690328" Name="3-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="123861094113690328" Name="1-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="138951586513690328" Name="2-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="93608296313690328" Name="2-0" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="135957046613690328" Name="3-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="191375991713690328" Name="0-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="133936749013690328" Name="2-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="177259741613690328" Name="3-0" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
								<Bet Id="34767597613690328" Name="0-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.423Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="41" Name="1st Period Winner">
							<Bets>
								<Bet Id="135832845413690328" Name="X" Status="2" StartPrice="1.0" Price="4.61" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.406Z" SuspensionReason="10" />
								<Bet Id="135832836713690328" Name="1" Status="2" StartPrice="1.0" Price="2.595" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.406Z" SuspensionReason="10" />
								<Bet Id="135832836413690328" Name="2" Status="2" StartPrice="1.0" Price="2.165" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.406Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="42" Name="2nd Period Winner">
							<Bets>
								<Bet Id="135832839913690328" Name="2" Status="2" StartPrice="1.0" Price="2.26" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.411Z" SuspensionReason="10" />
								<Bet Id="135832839613690328" Name="1" Status="2" StartPrice="1.0" Price="2.37" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.411Z" SuspensionReason="10" />
								<Bet Id="135832842113690328" Name="X" Status="2" StartPrice="1.0" Price="4.91" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.411Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="45" Name="Under/Over 2nd Period" MainLine="4.5">
							<Bets>
								<Bet Id="178854229413690328" Name="Under" Line="4.0" BaseLine="4.0" Status="2" StartPrice="1.0" Price="2.36" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.455Z" SuspensionReason="10" />
								<Bet Id="176039654013690328" Name="Over" Line="4.0" BaseLine="4.0" Status="2" StartPrice="1.0" Price="1.49" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.455Z" SuspensionReason="10" />
								<Bet Id="178854228913690328" Name="Under" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.83" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.455Z" SuspensionReason="10" />
								<Bet Id="178854213613690328" Name="Under" Line="3.5" BaseLine="3.5" Status="2" StartPrice="1.0" Price="2.89" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.455Z" SuspensionReason="10" />
								<Bet Id="143238027013690328" Name="Over" Line="3.5" BaseLine="3.5" Status="2" StartPrice="1.0" Price="1.34" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.455Z" SuspensionReason="10" />
								<Bet Id="177505586913690328" Name="Over" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.83" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.455Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="21" Name="Under/Over 1st Period" MainLine="4.0">
							<Bets>
								<Bet Id="163652656213690328" Name="Over" Line="4.0" BaseLine="4.0" Status="2" StartPrice="1.0" Price="1.968" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.449Z" SuspensionReason="10" />
								<Bet Id="49393012413690328" Name="Over" Line="3.5" BaseLine="3.5" Status="2" StartPrice="1.0" Price="1.625" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.449Z" SuspensionReason="10" />
								<Bet Id="89721465113690328" Name="Over" Line="3.0" BaseLine="3.0" Status="2" StartPrice="1.0" Price="1.315" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.449Z" SuspensionReason="10" />
								<Bet Id="7854980213690328" Name="Under" Line="3.5" BaseLine="3.5" Status="2" StartPrice="1.0" Price="2.285" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.449Z" SuspensionReason="10" />
								<Bet Id="7854970413690328" Name="Under" Line="4.0" BaseLine="4.0" Status="2" StartPrice="1.0" Price="1.84" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.449Z" SuspensionReason="10" />
								<Bet Id="7854980513690328" Name="Under" Line="3.0" BaseLine="3.0" Status="2" StartPrice="1.0" Price="3.22" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.449Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="456" Name="Double Chance 1st Period">
							<Bets>
								<Bet Id="42654904413690328" Name="X2" Status="2" StartPrice="1.0" Price="1.475" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.430Z" SuspensionReason="10" />
								<Bet Id="118658055513690328" Name="1X" Status="2" StartPrice="1.0" Price="1.66" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.430Z" SuspensionReason="10" />
								<Bet Id="118658059313690328" Name="12" Status="2" StartPrice="1.0" Price="1.18" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.430Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="457" Name="Double Chance 2nd Period">
							<Bets>
								<Bet Id="130805678013690328" Name="12" Status="2" StartPrice="1.0" Price="1.16" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.432Z" SuspensionReason="10" />
								<Bet Id="130805674213690328" Name="1X" Status="2" StartPrice="1.0" Price="1.6" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.432Z" SuspensionReason="10" />
								<Bet Id="179060322513690328" Name="X2" Status="2" StartPrice="1.0" Price="1.55" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.432Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="59" Name="Next Goal">
							<Bets>
								<Bet Id="1051448113690328" Name="1" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="1.945" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.439Z" SuspensionReason="10" />
								<Bet Id="1051339213690328" Name="2" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.439Z" SuspensionReason="10" />
								<Bet Id="202440367213690328" Name="No Goal" Line="1.0" BaseLine="1.0" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.439Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="153" Name="Under/Over 1st Period - Home Team" MainLine="2.0">
							<Bets>
								<Bet Id="153373370013690328" Name="Over" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="2.235" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.453Z" SuspensionReason="10" />
								<Bet Id="152927115013690328" Name="Under" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="1.65" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.453Z" SuspensionReason="10" />
							</Bets>
						</Market>
						<Market Id="154" Name="Under/Over 2nd Period - Home Team" MainLine="2.0">
							<Bets>
								<Bet Id="137947927513690328" Name="Over" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="1.66" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.458Z" SuspensionReason="10" />
								<Bet Id="199781345713690328" Name="Under" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="2.04" ProviderBetId="145" LastUpdate="2024-09-10T06:40:00.458Z" SuspensionReason="10" />
							</Bets>
						</Market>
					</Markets>
				</Event>
				<Event FixtureId="13699469">
					<Fixture LastUpdate="2024-09-10T06:36:33.721Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="54289" Name="E-Football | FIFA 23 Volta Daily League (E) | 2x3 Minutes" />
						<StartDate>2024-09-10T06:11:25.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53184433" Name="Paris Saint Germain (timmy)" Position="1" />
							<Participant Id="53090439" Name="Barcelona FC (ricky)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="0">
							<Score Position="1">5</Score>
							<Score Position="2">6</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">5</Score>
								<Score Position="2">6</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="0" ParticipantPosition="2">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">4</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="0" ParticipantPosition="1">
										<Score Position="1">5</Score>
										<Score Position="2">6</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">4</Score>
										<Score Position="2">5</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">3</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">2</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">4</Score>
										<Score Position="2">6</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">4</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">4</Score>
										<Score Position="2">4</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699470">
					<Fixture LastUpdate="2024-09-10T06:21:47.489Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="79" Name="Russia" />
						<League Id="78344" Name="Tournament Liga Pro Keeperball" />
						<StartDate>2024-09-10T06:10:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53694187" Name="Yantar-Pro" Position="1" />
							<Participant Id="53694186" Name="Djoker-pro" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699471">
					<Fixture LastUpdate="2024-09-10T06:45:30.072Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:15:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53636286" Name="Paris Saint Germain (odin)" Position="1" />
							<Participant Id="53627462" Name="Fc Barcelona (popeye)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="5400">
							<Score Position="1">4</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">0</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699480">
					<Fixture LastUpdate="2024-09-10T06:34:27.245Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:20:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53697209" Name="Bayern (Mj) Esports" Position="1" />
							<Participant Id="53700209" Name="Real Madrid (bullfrog)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">3</Score>
							<Score Position="2">0</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">0</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">0</Score>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="2">
								<Value Position="1">3</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">29</Value>
								<Value Position="2">24</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">13</Value>
								<Value Position="2">15</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699482">
					<Fixture LastUpdate="2024-09-10T06:46:54.253Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="69749" Name="Short Football D1" />
						<StartDate>2024-09-10T06:21:19.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53557760" Name="Bison (3X3)" Position="1" />
							<Participant Id="53572628" Name="Owls (3X3)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="5400">
							<Score Position="1">10</Score>
							<Score Position="2">9</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">10</Score>
								<Score Position="2">9</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">5</Score>
								<Score Position="2">3</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="300" ParticipantPosition="2">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="360" ParticipantPosition="1">
										<Score Position="1">3</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="420" ParticipantPosition="1">
										<Score Position="1">4</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="480" ParticipantPosition="1">
										<Score Position="1">5</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="5400" ParticipantPosition="2">
										<Score Position="1">5</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">5</Score>
								<Score Position="2">6</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">9</Score>
										<Score Position="2">8</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">9</Score>
										<Score Position="2">6</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">8</Score>
										<Score Position="2">5</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">9</Score>
										<Score Position="2">9</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">9</Score>
										<Score Position="2">7</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">7</Score>
										<Score Position="2">4</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">5</Score>
										<Score Position="2">4</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">8</Score>
										<Score Position="2">4</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">6</Score>
										<Score Position="2">4</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">9</Score>
										<Score Position="2">5</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="5400" ParticipantPosition="1">
										<Score Position="1">10</Score>
										<Score Position="2">9</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699488">
					<Fixture LastUpdate="2024-09-10T06:45:48.109Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:36:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53733615" Name="Portugal (kravatskhelia)" Position="1" />
							<Participant Id="52473681" Name="Italy (nikkitta)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">0</Score>
							<Score Position="2">4</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">4</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">4</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699489">
					<Fixture LastUpdate="2024-09-10T06:44:11.313Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:44:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="52401941" Name="Tottenham (Flewless_phoenix) (E)" Position="1" />
							<Participant Id="52449764" Name="Arsenal (Sane4ek8)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699490">
					<Fixture LastUpdate="2024-09-10T06:44:11.313Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:44:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="52503497" Name="Manchester United (Labotryas)" Position="1" />
							<Participant Id="52404792" Name="Manchester City (KRaftVK) (E)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699491">
					<Fixture LastUpdate="2024-09-10T06:48:42.588Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:48:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="52616158" Name="Spain (lion)" Position="1" />
							<Participant Id="53733615" Name="Portugal (kravatskhelia)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699492">
					<Fixture LastUpdate="2024-09-10T06:48:51.623Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:48:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53565347" Name="Germany (koftovsky)" Position="1" />
							<Participant Id="52408970" Name="England (Arcos) (E)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699493">
					<Fixture LastUpdate="2024-09-10T06:46:27.188Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:36:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52408970" Name="England (Arcos) (E)" Position="1" />
							<Participant Id="52616158" Name="Spain (lion)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">4</Score>
							<Score Position="2">0</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">0</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">0</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699499">
					<Fixture LastUpdate="2024-09-10T06:40:19.450Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53706294" Name="France (chipper)" Position="1" />
							<Participant Id="53725203" Name="England (comet)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">2</Score>
							<Score Position="2">1</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="-1" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">0</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="240" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="2">
								<Value Position="1">2</Value>
								<Value Position="2">1</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">21</Value>
								<Value Position="2">23</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">18</Value>
								<Value Position="2">17</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699502">
					<Fixture LastUpdate="2024-09-10T06:30:59.208Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="65306" Name="USSR 3X3" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53521215" Name="Ukraine (3x3)" Position="1" />
							<Participant Id="53528733" Name="Georgia (3X3)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699504">
					<Fixture LastUpdate="2024-09-10T06:30:59.208Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="65306" Name="USSR 3X3" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53452980" Name="USSR (3X3)" Position="1" />
							<Participant Id="53378628" Name="Argentina (3x3)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699232">
					<Fixture LastUpdate="2024-09-10T06:22:05.760Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53596414" Name="Italy (andrew)" Position="1" />
							<Participant Id="53534953" Name="Argentina (matrix)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="2400">
							<Score Position="1">2</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699233">
					<Fixture LastUpdate="2024-09-10T06:26:19.266Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53522853" Name="France (obelix)" Position="1" />
							<Participant Id="53730995" Name="England (logan)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="2400">
							<Score Position="1">4</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">2</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13696742">
					<Fixture LastUpdate="2024-09-10T06:45:27.065Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="69749" Name="Short Football D1" />
						<StartDate>2024-09-10T06:20:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53551048" Name="Arsenal (4X4)" Position="1" />
							<Participant Id="53548348" Name="Khimik (4X4)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="5400">
							<Score Position="1">2</Score>
							<Score Position="2">8</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">8</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">4</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="360" ParticipantPosition="2">
										<Score Position="1">0</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="480" ParticipantPosition="2">
										<Score Position="1">0</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="480" ParticipantPosition="1">
										<Score Position="1">1</Score>
										<Score Position="2">3</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="5400" ParticipantPosition="2">
										<Score Position="1">1</Score>
										<Score Position="2">4</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">4</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">2</Score>
										<Score Position="2">5</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">2</Score>
										<Score Position="2">7</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">2</Score>
										<Score Position="2">6</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">2</Score>
										<Score Position="2">4</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="5400" ParticipantPosition="2">
										<Score Position="1">2</Score>
										<Score Position="2">8</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
					<Markets>
						<Market Id="155" Name="Under/Over 1st Period - Away Team" MainLine="2.0">
							<Bets>
								<Bet Id="41221026813696742" Name="Over" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.71" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:32:36.583Z" />
								<Bet Id="78379148213696742" Name="Under" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.97" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:32:36.583Z" />
							</Bets>
						</Market>
						<Market Id="1" Name="1X2">
							<Bets>
								<Bet Id="11062164413696742" Name="2" Status="3" StartPrice="1.0" Price="2.21" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="167670558513696742" Name="1" Status="3" StartPrice="1.0" Price="2.11" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="212086885013696742" Name="X" Status="3" StartPrice="1.0" Price="6.98" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
						<Market Id="64" Name="Asian Handicap 1st Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="159233547113696742" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.86" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="155438612913696742" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.26" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="158884753413696742" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.29" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="155550235213696742" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.8" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="200563550313696742" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.32" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="197103028613696742" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.16" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
							</Bets>
						</Market>
						<Market Id="2" Name="Under/Over" MainLine="9.5">
							<Bets>
								<Bet Id="22319133613696742" Name="Under" Line="8.5" BaseLine="8.5" Status="3" StartPrice="1.0" Price="2.17" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="165260250513696742" Name="Over" Line="9.5" BaseLine="9.5" Status="3" StartPrice="1.0" Price="2.05" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:42:12.792Z" />
								<Bet Id="176907230113696742" Name="Under" Line="9.5" BaseLine="9.5" Status="3" StartPrice="1.0" Price="1.65" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:42:12.792Z" />
								<Bet Id="165260260013696742" Name="Over" Line="8.5" BaseLine="8.5" Status="3" StartPrice="1.0" Price="1.58" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
							</Bets>
						</Market>
						<Market Id="65" Name="Asian Handicap 2nd Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="209235556713696742" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.3" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="213142139213696742" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.27" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="174690181113696742" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.1" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="213030516913696742" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.8" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="178582369613696742" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.27" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="208886763013696742" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.86" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
						<Market Id="3" Name="Asian Handicap" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="181920804413696742" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.87" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="11056552113696742" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.43" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="22330397813696742" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.39" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="142056973713696742" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="2.53" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="180829362613696742" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="2.69" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="20406656513696742" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.79" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
						<Market Id="5" Name="Odd/Even">
							<Bets>
								<Bet Id="55417100713696742" Name="Odd" Status="3" StartPrice="1.0" Price="1.87" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="188217264813696742" Name="Even" Status="3" StartPrice="1.0" Price="1.87" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
						<Market Id="6" Name="Correct Score">
							<Bets>
								<Bet Id="39022461113696742" Name="4-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="181514605113696742" Name="5-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:37:48.610Z" />
								<Bet Id="155302402513696742" Name="4-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:33:48.379Z" />
								<Bet Id="117585933013696742" Name="4-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:37:48.610Z" />
								<Bet Id="13401944113696742" Name="6-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:33:48.379Z" />
								<Bet Id="195630855213696742" Name="4-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="65234663713696742" Name="5-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="11381646513696742" Name="3-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="145226747613696742" Name="3-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="141186152413696742" Name="5-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:33:48.379Z" />
								<Bet Id="67254961313696742" Name="6-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="28946806213696742" Name="3-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:33:48.379Z" />
								<Bet Id="24906211013696742" Name="5-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="127661587913696742" Name="3-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:37:48.610Z" />
								<Bet Id="89353432813696742" Name="6-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:37:48.610Z" />
							</Bets>
						</Market>
						<Market Id="100" Name="Correct Score 2nd Period">
							<Bets>
								<Bet Id="120933989613696742" Name="1-4" Status="3" StartPrice="1.0" Price="10" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="113646190813696742" Name="0-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:36:24.678Z" />
								<Bet Id="85413690613696742" Name="2-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="201590895013696742" Name="1-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="189494942513696742" Name="3-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="123721845713696742" Name="3-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:42:12.792Z" />
								<Bet Id="149166489813696742" Name="3-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="13502797113696742" Name="4-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="9462201913696742" Name="2-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="161262442313696742" Name="1-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="111625893213696742" Name="1-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:37:48.610Z" />
								<Bet Id="125742143313696742" Name="2-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="30866250813696742" Name="2-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:42:12.792Z" />
								<Bet Id="187474644913696742" Name="2-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:37:48.610Z" />
								<Bet Id="32886548413696742" Name="3-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="170111191213696742" Name="4-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="143105597013696742" Name="4-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:42:12.792Z" />
								<Bet Id="44982500913696742" Name="1-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:42:12.792Z" />
								<Bet Id="42962203313696742" Name="0-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:36:24.678Z" />
							</Bets>
						</Market>
						<Market Id="7" Name="Double Chance">
							<Bets>
								<Bet Id="82591703613696742" Name="X2" Status="3" StartPrice="1.0" Price="1.68" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="178329835913696742" Name="1X" Status="3" StartPrice="1.0" Price="1.62" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="178329844913696742" Name="12" Status="3" StartPrice="1.0" Price="1" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
						<Market Id="101" Name="Under/Over - Home Team" MainLine="4.5">
							<Bets>
								<Bet Id="72361399813696742" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.83" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="162835285413696742" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.83" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
						<Market Id="9" Name="Correct Score 1st Period">
							<Bets>
								<Bet Id="151498668613696742" Name="0-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="161718119613696742" Name="0-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:31:09.784Z" />
								<Bet Id="133485619413696742" Name="2-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:31:09.784Z" />
								<Bet Id="173814072113696742" Name="2-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="113190513513696742" Name="1-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:31:09.784Z" />
								<Bet Id="101094561013696742" Name="3-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="15185380413696742" Name="3-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="153518966213696742" Name="1-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="159697822013696742" Name="1-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:26:40.584Z" />
								<Bet Id="139402716113696742" Name="2-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:26:40.584Z" />
								<Bet Id="171793774513696742" Name="3-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="211313609613696742" Name="4-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:31:09.784Z" />
								<Bet Id="61574725913696742" Name="4-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="131465321813696742" Name="3-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:26:40.584Z" />
								<Bet Id="3089427913696742" Name="1-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="17205678013696742" Name="2-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="95033668213696742" Name="4-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="72862060813696742" Name="1-4" Status="3" StartPrice="1.0" Price="10" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="57534130713696742" Name="2-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="5109725513696742" Name="0-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="141423013713696742" Name="3-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:31:09.784Z" />
							</Bets>
						</Market>
						<Market Id="102" Name="Under/Over - Away Team" MainLine="4.5">
							<Bets>
								<Bet Id="212965838313696742" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.88" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:37:48.610Z" />
								<Bet Id="109462307313696742" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.78" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:37:48.610Z" />
							</Bets>
						</Market>
						<Market Id="41" Name="1st Period Winner">
							<Bets>
								<Bet Id="11984685913696742" Name="1" Status="3" StartPrice="1.0" Price="2.28" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="11984690013696742" Name="X" Status="3" StartPrice="1.0" Price="4.85" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="11984686213696742" Name="2" Status="3" StartPrice="1.0" Price="2.36" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
							</Bets>
						</Market>
						<Market Id="42" Name="2nd Period Winner">
							<Bets>
								<Bet Id="11984683013696742" Name="1" Status="3" StartPrice="1.0" Price="2.26" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="11984693313696742" Name="X" Status="3" StartPrice="1.0" Price="4.95" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="11984682713696742" Name="2" Status="3" StartPrice="1.0" Price="2.35" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
						<Market Id="45" Name="Under/Over 2nd Period" MainLine="4.5">
							<Bets>
								<Bet Id="159655260813696742" Name="Over" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="1.31" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="65131595113696742" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.88" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:42:12.792Z" />
								<Bet Id="65131579813696742" Name="Under" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="3.01" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:40:42.580Z" />
								<Bet Id="5067164313696742" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.78" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:42:12.792Z" />
							</Bets>
						</Market>
						<Market Id="21" Name="Under/Over 1st Period" MainLine="4.5">
							<Bets>
								<Bet Id="98763158313696742" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.91" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:33:48.379Z" />
								<Bet Id="108970218013696742" Name="Under" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="2.74" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:33:48.379Z" />
								<Bet Id="108970227513696742" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.75" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:33:48.379Z" />
								<Bet Id="133030718213696742" Name="Over" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="1.37" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:33:48.379Z" />
							</Bets>
						</Market>
						<Market Id="456" Name="Double Chance 1st Period">
							<Bets>
								<Bet Id="145784433413696742" Name="X2" Status="3" StartPrice="1.0" Price="1.59" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="194039077913696742" Name="12" Status="3" StartPrice="1.0" Price="1.16" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="194039086913696742" Name="1X" Status="3" StartPrice="1.0" Price="1.55" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
							</Bets>
						</Market>
						<Market Id="457" Name="Double Chance 2nd Period">
							<Bets>
								<Bet Id="206186696613696742" Name="12" Status="3" StartPrice="1.0" Price="1.15" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="147306878113696742" Name="X2" Status="3" StartPrice="1.0" Price="1.59" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="206186705613696742" Name="1X" Status="3" StartPrice="1.0" Price="1.55" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
						<Market Id="59" Name="Next Goal">
							<Bets>
								<Bet Id="77395167913696742" Name="No Goal" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="9" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:31:09.784Z" />
								<Bet Id="14373797313696742" Name="2" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.89" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:31:09.784Z" />
								<Bet Id="14373695013696742" Name="1" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.86" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:31:09.784Z" />
							</Bets>
						</Market>
						<Market Id="153" Name="Under/Over 1st Period - Home Team" MainLine="2.0">
							<Bets>
								<Bet Id="24741540613696742" Name="Over" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.67" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
								<Bet Id="92416073213696742" Name="Under" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="2.03" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:34:39.580Z" />
							</Bets>
						</Market>
						<Market Id="154" Name="Under/Over 2nd Period - Home Team" MainLine="2.5">
							<Bets>
								<Bet Id="169563661413696742" Name="Under" Line="2.5" BaseLine="2.5" Status="3" StartPrice="1.0" Price="1.6" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
								<Bet Id="26292608613696742" Name="Over" Line="2.5" BaseLine="2.5" Status="3" StartPrice="1.0" Price="2.14" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:23.979Z" />
							</Bets>
						</Market>
					</Markets>
				</Event>
				<Event FixtureId="13699236">
					<Fixture LastUpdate="2024-09-10T06:22:44.838Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53542926" Name="atletico madrid (eduardo)" Position="1" />
							<Participant Id="53627462" Name="Fc Barcelona (popeye)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="2400">
							<Score Position="1">2</Score>
							<Score Position="2">0</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">0</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">0</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699237">
					<Fixture LastUpdate="2024-09-10T06:25:18.657Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53523437" Name="manchester city fc (vangogh)" Position="1" />
							<Participant Id="53519517" Name="bayern munich (spiderman)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="2400">
							<Score Position="1">4</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">0</Score>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699518">
					<Fixture LastUpdate="2024-09-10T06:31:38.273Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T07:24:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727216" Name="Rcd Mallorca (henry)" Position="1" />
							<Participant Id="53727217" Name="Real Betis (pedro)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699527">
					<Fixture LastUpdate="2024-09-10T06:49:40.071Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:34:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53708238" Name="Manchester City (radical)" Position="1" />
							<Participant Id="53695370" Name="Paris Saint Germain (lava)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="480">
							<Score Position="1">4</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">4</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="300" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">4</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="2">
								<Value Position="1">4</Value>
								<Value Position="2">2</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">16</Value>
								<Value Position="2">21</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">12</Value>
								<Value Position="2">15</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13696761">
					<Fixture LastUpdate="2024-09-10T06:21:26.681Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="69749" Name="Short Football D1" />
						<StartDate>2024-09-10T05:53:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53548346" Name="Neman (4X4)" Position="1" />
							<Participant Id="53550431" Name="Shakhtar (4X4)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="5400">
							<Score Position="1">3</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="2">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="5400" ParticipantPosition="1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="false" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">2</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="1">
										<Score Position="1">3</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="2700" ParticipantPosition="2">
										<Score Position="1">3</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="5400" ParticipantPosition="2">
										<Score Position="1">3</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<LivescoreExtraData />
					</Livescore>
					<Markets>
						<Market Id="155" Name="Under/Over 1st Period - Away Team" MainLine="2.0">
							<Bets>
								<Bet Id="203664644113696761" Name="Under" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="2.04" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="61539667313696761" Name="Over" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.66" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
							</Bets>
						</Market>
						<Market Id="1" Name="1X2">
							<Bets>
								<Bet Id="57607237413696761" Name="1" Status="3" StartPrice="1.0" Price="2.22" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="180612893113696761" Name="X" Status="3" StartPrice="1.0" Price="6.98" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="99001156713696761" Name="2" Status="3" StartPrice="1.0" Price="2.1" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="2" Name="Under/Over" MainLine="9.5">
							<Bets>
								<Bet Id="12498489213696761" Name="Under" Line="9.5" BaseLine="9.5" Status="3" StartPrice="1.0" Price="1.65" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="74401726913696761" Name="Over" Line="8.5" BaseLine="8.5" Status="3" StartPrice="1.0" Price="1.58" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="74401717413696761" Name="Over" Line="9.5" BaseLine="9.5" Status="3" StartPrice="1.0" Price="2.05" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="26614739313696761" Name="Under" Line="8.5" BaseLine="8.5" Status="3" StartPrice="1.0" Price="2.17" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="64" Name="Asian Handicap 1st Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="116067975313696761" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.87" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="163530504213696761" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.14" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="144444574913696761" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.34" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="135056650713696761" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.26" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="135405444413696761" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.79" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="115956353013696761" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.29" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
							</Bets>
						</Market>
						<Market Id="65" Name="Asian Handicap 2nd Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="185058660313696761" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.79" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="185407454013696761" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.27" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="202148094813696761" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.29" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="173548257013696761" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.87" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="213881313913696761" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.08" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="173659879313696761" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.3" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="3" Name="Asian Handicap" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="211537021813696761" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.88" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="112053880913696761" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="2.51" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="7285819613696761" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.38" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="73281492013696761" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="2.71" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="40672769513696761" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.44" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="9209560913696761" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.78" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="5" Name="Odd/Even">
							<Bets>
								<Bet Id="175250446013696761" Name="Odd" Status="3" StartPrice="1.0" Price="1.87" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="213998277513696761" Name="Even" Status="3" StartPrice="1.0" Price="1.87" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="6" Name="Correct Score">
							<Bets>
								<Bet Id="155918773013696761" Name="6-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="196247225713696761" Name="6-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="39638831613696761" Name="6-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="74620812213696761" Name="5-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="205017003713696761" Name="4-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="41659129213696761" Name="5-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="202996706113696761" Name="3-3" Status="3" StartPrice="1.0" Price="10" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="12785573613696761" Name="4-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="88737062313696761" Name="4-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="1330676513696761" Name="5-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="67871331813696761" Name="4-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="145843118113696761" Name="3-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="10765276013696761" Name="3-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="127045217413696761" Name="3-6" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="81987581913696761" Name="5-5" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="100" Name="Correct Score 2nd Period">
							<Bets>
								<Bet Id="48079479813696761" Name="0-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:13:48.000Z" />
								<Bet Id="148222873513696761" Name="4-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:19:21.181Z" />
								<Bet Id="74291682413696761" Name="3-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="134741116913696761" Name="1-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:13:48.000Z" />
								<Bet Id="212712903213696761" Name="2-2" Status="3" StartPrice="1.0" Price="10" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="94412664213696761" Name="1-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:13:48.000Z" />
								<Bet Id="8385520613696761" Name="4-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="164993914713696761" Name="4-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="96432961813696761" Name="2-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:15:29.927Z" />
								<Bet Id="60175432313696761" Name="2-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="204687873913696761" Name="0-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:13:48.000Z" />
								<Bet Id="190571623813696761" Name="3-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:19:21.181Z" />
								<Bet Id="210692605613696761" Name="1-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:13:48.000Z" />
								<Bet Id="62195729913696761" Name="1-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:13:48.000Z" />
								<Bet Id="82316711713696761" Name="3-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="176455373713696761" Name="2-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:19:21.181Z" />
								<Bet Id="162973617113696761" Name="3-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="178475671313696761" Name="1-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:13:48.000Z" />
								<Bet Id="136126921013696761" Name="2-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="7" Name="Double Chance">
							<Bets>
								<Bet Id="30826613413696761" Name="1X" Status="3" StartPrice="1.0" Price="1.69" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="30826617613696761" Name="12" Status="3" StartPrice="1.0" Price="1" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="106321121313696761" Name="X2" Status="3" StartPrice="1.0" Price="1.61" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="101" Name="Under/Over - Home Team" MainLine="4.5">
							<Bets>
								<Bet Id="37222544113696761" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.77" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="133569064113696761" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.89" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="102" Name="Under/Over - Away Team" MainLine="4.5">
							<Bets>
								<Bet Id="187264670013696761" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.82" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="210450478413696761" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.84" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="9" Name="Correct Score 1st Period">
							<Bets>
								<Bet Id="199719492713696761" Name="3-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:02:58.980Z" />
								<Bet Id="169466694913696761" Name="0-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="46956640213696761" Name="4-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="41090801013696761" Name="2-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:02:58.980Z" />
								<Bet Id="171486992513696761" Name="1-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:02:58.980Z" />
								<Bet Id="55207051113696761" Name="1-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="159391040013696761" Name="3-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="61072890313696761" Name="1-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="101401343013696761" Name="1-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="14878598413696761" Name="1-1" Status="3" StartPrice="1.0" Price="10" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="157370742413696761" Name="2-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="103421640613696761" Name="0-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="113497295513696761" Name="3-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="203565034313696761" Name="4-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="109651753913696761" Name="4-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="32840390113696761" Name="3-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="115517593113696761" Name="2-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="197699195113696761" Name="2-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="43111098613696761" Name="3-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="191469081813696761" Name="2-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="53186753513696761" Name="0-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
							</Bets>
						</Market>
						<Market Id="41" Name="1st Period Winner">
							<Bets>
								<Bet Id="43588493313696761" Name="X" Status="3" StartPrice="1.0" Price="4.85" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="43588484613696761" Name="1" Status="3" StartPrice="1.0" Price="2.37" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="43588484713696761" Name="2" Status="3" StartPrice="1.0" Price="2.27" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
							</Bets>
						</Market>
						<Market Id="42" Name="2nd Period Winner">
							<Bets>
								<Bet Id="43588500613696761" Name="2" Status="3" StartPrice="1.0" Price="2.25" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="43588500713696761" Name="1" Status="3" StartPrice="1.0" Price="2.36" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="43588503213696761" Name="X" Status="3" StartPrice="1.0" Price="4.95" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="45" Name="Under/Over 2nd Period" MainLine="4.5">
							<Bets>
								<Bet Id="9450521813696761" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.88" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="9450493313696761" Name="Under" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="3.01" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:19:21.181Z" />
								<Bet Id="117071092513696761" Name="Over" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="1.31" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:19:21.181Z" />
								<Bet Id="166810378613696761" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.78" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="21" Name="Under/Over 1st Period" MainLine="4.5">
							<Bets>
								<Bet Id="24711458813696761" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.75" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="143175153113696761" Name="Over" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="1.37" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="65203366813696761" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.91" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="24711462513696761" Name="Under" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="2.74" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
							</Bets>
						</Market>
						<Market Id="456" Name="Double Chance 1st Period">
							<Bets>
								<Bet Id="209733436713696761" Name="X2" Status="3" StartPrice="1.0" Price="1.54" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="206873344813696761" Name="1X" Status="3" StartPrice="1.0" Price="1.59" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="206873353413696761" Name="12" Status="3" StartPrice="1.0" Price="1.16" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
							</Bets>
						</Market>
						<Market Id="457" Name="Double Chance 2nd Period">
							<Bets>
								<Bet Id="73328018613696761" Name="X2" Status="3" StartPrice="1.0" Price="1.55" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="210475766113696761" Name="1X" Status="3" StartPrice="1.0" Price="1.6" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="210475757513696761" Name="12" Status="3" StartPrice="1.0" Price="1.15" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
						<Market Id="59" Name="Next Goal">
							<Bets>
								<Bet Id="198182667113696761" Name="2" Line="1.0" BaseLine="1.0" Status="3" StartPrice="1.0" Price="1.85" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:02:58.980Z" />
								<Bet Id="176653265513696761" Name="No Goal" Line="1.0" BaseLine="1.0" Status="3" StartPrice="1.0" Price="9" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:02:58.980Z" />
								<Bet Id="198182993813696761" Name="1" Line="1.0" BaseLine="1.0" Status="3" StartPrice="1.0" Price="1.89" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:02:58.980Z" />
							</Bets>
						</Market>
						<Market Id="153" Name="Under/Over 1st Period - Home Team" MainLine="2.0">
							<Bets>
								<Bet Id="41331753513696761" Name="Over" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.71" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
								<Bet Id="42138691113696761" Name="Under" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.96" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:09:23.781Z" />
							</Bets>
						</Market>
						<Market Id="154" Name="Under/Over 2nd Period - Home Team" MainLine="2.0">
							<Bets>
								<Bet Id="5973968413696761" Name="Over" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.62" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
								<Bet Id="72151678213696761" Name="Under" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="2.1" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:22:26.286Z" />
							</Bets>
						</Market>
					</Markets>
				</Event>
				<Event FixtureId="13699532">
					<Fixture LastUpdate="2024-09-10T06:41:25.706Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="54289" Name="E-Football | FIFA 23 Volta Daily League (E) | 2x3 Minutes" />
						<StartDate>2024-09-10T06:32:14.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53596312" Name="Dortmund (cero)" Position="1" />
							<Participant Id="53090439" Name="Barcelona FC (ricky)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699533">
					<Fixture LastUpdate="2024-09-10T06:36:48.560Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T07:26:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727224" Name="Sevilla Fc (bastony)" Position="1" />
							<Participant Id="53735716" Name="Real Madrid (holis)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699536">
					<Fixture LastUpdate="2024-09-10T06:38:15.169Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="79316" Name="E-Football | Valkyrie Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:38:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53730140" Name="Arsenal (quinnie)" Position="1" />
							<Participant Id="53715496" Name="Manchester United (darlly)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699537">
					<Fixture LastUpdate="2024-09-10T06:38:21.957Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:15:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53730995" Name="England (logan)" Position="1" />
							<Participant Id="53522853" Name="France (obelix)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699538">
					<Fixture LastUpdate="2024-09-10T06:38:57.541Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:15:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53534953" Name="Argentina (matrix)" Position="1" />
							<Participant Id="53596414" Name="Italy (andrew)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699539">
					<Fixture LastUpdate="2024-09-10T06:39:03.091Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:30:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53523437" Name="manchester city fc (vangogh)" Position="1" />
							<Participant Id="53542926" Name="atletico madrid (eduardo)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699541">
					<Fixture LastUpdate="2024-09-10T06:39:04.602Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:30:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53627462" Name="Fc Barcelona (popeye)" Position="1" />
							<Participant Id="53636286" Name="Paris Saint Germain (odin)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699542">
					<Fixture LastUpdate="2024-09-10T06:39:04.764Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:15:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53519517" Name="bayern munich (spiderman)" Position="1" />
							<Participant Id="53523437" Name="manchester city fc (vangogh)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699543">
					<Fixture LastUpdate="2024-09-10T06:39:05.280Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T07:15:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53627462" Name="Fc Barcelona (popeye)" Position="1" />
							<Participant Id="53542926" Name="atletico madrid (eduardo)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699546">
					<Fixture LastUpdate="2024-09-10T06:40:07.319Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="196" Name="China" />
						<League Id="75190" Name="Championship U19" />
						<StartDate>2024-09-10T06:30:01.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53744848" Name="Henan U19" Position="1" />
							<Participant Id="53744849" Name="Wuhan Three Towns U19" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699547">
					<Fixture LastUpdate="2024-09-10T06:40:03.098Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="79316" Name="E-Football | Valkyrie Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:40:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53716893" Name="Chelsea (brenda)" Position="1" />
							<Participant Id="53742332" Name="Manchester City (destiny)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13696778">
					<Fixture LastUpdate="2024-09-09T17:38:55.666Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="69749" Name="Short Football D1" />
						<StartDate>2024-09-10T07:35:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53548348" Name="Khimik (4X4)" Position="1" />
							<Participant Id="53548345" Name="Granit (4X4)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Markets>
						<Market Id="155" Name="Under/Over 1st Period - Away Team" MainLine="2.0">
							<Bets>
								<Bet Id="152677700313696778" Name="Over" Line="2.0" BaseLine="2.0" Status="1" StartPrice="1.0" Price="1.71" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.898Z" />
								<Bet Id="167291952513696778" Name="Under" Line="2.0" BaseLine="2.0" Status="1" StartPrice="1.0" Price="1.97" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.898Z" />
							</Bets>
						</Market>
						<Market Id="1" Name="1X2">
							<Bets>
								<Bet Id="195714518813696778" Name="1" Status="1" StartPrice="1.0" Price="2.1" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.887Z" />
								<Bet Id="212275424913696778" Name="X" Status="1" StartPrice="1.0" Price="6.98" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.887Z" />
								<Bet Id="155386066113696778" Name="2" Status="1" StartPrice="1.0" Price="2.22" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.887Z" />
							</Bets>
						</Market>
						<Market Id="64" Name="Asian Handicap 1st Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="8842744213696778" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="1" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.888Z" />
								<Bet Id="188280649613696778" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="1" StartPrice="1.0" Price="3.33" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.888Z" />
								<Bet Id="200013868713696778" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="1" StartPrice="1.0" Price="3.15" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.888Z" />
								<Bet Id="20241525213696778" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="1" StartPrice="1.0" Price="1.26" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.888Z" />
								<Bet Id="20353147513696778" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="1" StartPrice="1.0" Price="1.79" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.888Z" />
								<Bet Id="8493950513696778" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="1" StartPrice="1.0" Price="1.29" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.888Z" />
							</Bets>
						</Market>
						<Market Id="2" Name="Under/Over" MainLine="9.5">
							<Bets>
								<Bet Id="89199586413696778" Name="Over" Line="9.5" BaseLine="9.5" Status="1" StartPrice="1.0" Price="2.05" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.877Z" />
								<Bet Id="100361522713696778" Name="Under" Line="8.5" BaseLine="8.5" Status="1" StartPrice="1.0" Price="2.18" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.877Z" />
								<Bet Id="54226573813696778" Name="Under" Line="9.5" BaseLine="9.5" Status="1" StartPrice="1.0" Price="1.66" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.877Z" />
								<Bet Id="89199583113696778" Name="Over" Line="8.5" BaseLine="8.5" Status="1" StartPrice="1.0" Price="1.58" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.877Z" />
							</Bets>
						</Market>
						<Market Id="65" Name="Asian Handicap 2nd Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="171779341013696778" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="1" StartPrice="1.0" Price="3.09" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.900Z" />
								<Bet Id="58844753813696778" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="1" StartPrice="1.0" Price="1.3" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.900Z" />
								<Bet Id="77945051513696778" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="1" StartPrice="1.0" Price="1.27" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.900Z" />
								<Bet Id="190865270313696778" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="1" StartPrice="1.0" Price="3.28" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.900Z" />
								<Bet Id="58495960113696778" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="1" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.900Z" />
								<Bet Id="77833429213696778" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="1" StartPrice="1.0" Price="1.79" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.900Z" />
							</Bets>
						</Market>
						<Market Id="3" Name="Asian Handicap" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="5908422113696778" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="1" StartPrice="1.0" Price="1.38" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.894Z" />
								<Bet Id="207390769413696778" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="1" StartPrice="1.0" Price="1.44" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.894Z" />
								<Bet Id="122105457013696778" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="1" StartPrice="1.0" Price="2.52" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.894Z" />
								<Bet Id="133254294913696778" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="1" StartPrice="1.0" Price="2.7" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.894Z" />
								<Bet Id="36526517113696778" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="1" StartPrice="1.0" Price="1.88" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.894Z" />
								<Bet Id="3984680813696778" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="1" StartPrice="1.0" Price="1.78" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.894Z" />
							</Bets>
						</Market>
						<Market Id="5" Name="Odd/Even">
							<Bets>
								<Bet Id="107487079713696778" Name="Even" Status="1" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.881Z" />
								<Bet Id="198025787413696778" Name="Odd" Status="1" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.881Z" />
							</Bets>
						</Market>
						<Market Id="6" Name="Correct Score">
							<Bets>
								<Bet Id="204464550313696778" Name="5-5" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="123807644913696778" Name="5-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="68423785213696778" Name="5-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="47856156213696778" Name="5-6" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="178252347713696778" Name="4-6" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="4568249013696778" Name="3-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="210915929213696778" Name="4-5" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="61972406313696778" Name="4-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="80519737713696778" Name="3-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="122868488013696778" Name="6-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="120848190413696778" Name="3-6" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="190348300213696778" Name="6-5" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="161176643113696778" Name="3-5" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="137923895013696778" Name="4-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
								<Bet Id="33739906113696778" Name="6-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.874Z" />
							</Bets>
						</Market>
						<Market Id="7" Name="Double Chance">
							<Bets>
								<Bet Id="51091066413696778" Name="1X" Status="1" StartPrice="1.0" Price="1.62" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.903Z" />
								<Bet Id="92213516713696778" Name="X2" Status="1" StartPrice="1.0" Price="1.68" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.903Z" />
								<Bet Id="51091077013696778" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.903Z" SuspensionReason="1" />
							</Bets>
						</Market>
						<Market Id="100" Name="Correct Score 2nd Period">
							<Bets>
								<Bet Id="10215771713696778" Name="4-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="108338867813696778" Name="1-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="176899820713696778" Name="3-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="7941073613696778" Name="1-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="96242915313696778" Name="3-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="136571368013696778" Name="3-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="106064169713696778" Name="4-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="98263212913696778" Name="2-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="93968217213696778" Name="2-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="174625122613696778" Name="2-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="50544224413696778" Name="4-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="48269526313696778" Name="1-0" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="176645420213696778" Name="3-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="5920776013696778" Name="0-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="164549467713696778" Name="1-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="18016728513696778" Name="2-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="138591665613696778" Name="2-0" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="46249228713696778" Name="0-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
								<Bet Id="148667320513696778" Name="1-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.883Z" />
							</Bets>
						</Market>
						<Market Id="101" Name="Under/Over - Home Team" MainLine="4.5">
							<Bets>
								<Bet Id="65678069113696778" Name="Under" Line="4.5" BaseLine="4.5" Status="1" StartPrice="1.0" Price="1.84" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.884Z" />
								<Bet Id="58717357113696778" Name="Over" Line="4.5" BaseLine="4.5" Status="1" StartPrice="1.0" Price="1.82" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.884Z" />
							</Bets>
						</Market>
						<Market Id="9" Name="Correct Score 1st Period">
							<Bets>
								<Bet Id="141506333513696778" Name="3-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="55430513313696778" Name="3-0" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="197922657313696778" Name="0-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="62869725713696778" Name="2-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="199942954913696778" Name="1-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="129361704413696778" Name="2-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="141457656913696778" Name="4-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="101177880813696778" Name="3-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="43334560813696778" Name="1-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="53410215713696778" Name="2-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="60849428113696778" Name="3-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="103198178413696778" Name="2-0" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="83663013513696778" Name="1-0" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="41314263213696778" Name="0-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="212038907413696778" Name="3-3" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="25177715513696778" Name="4-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="210018609813696778" Name="2-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="72945380613696778" Name="1-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="113273833313696778" Name="1-4" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="15150737213696778" Name="4-2" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
								<Bet Id="81642715913696778" Name="0-1" Status="1" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.897Z" />
							</Bets>
						</Market>
						<Market Id="102" Name="Under/Over - Away Team" MainLine="4.5">
							<Bets>
								<Bet Id="131602612613696778" Name="Over" Line="4.5" BaseLine="4.5" Status="1" StartPrice="1.0" Price="1.88" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.876Z" />
								<Bet Id="151413019013696778" Name="Under" Line="4.5" BaseLine="4.5" Status="1" StartPrice="1.0" Price="1.78" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.876Z" />
							</Bets>
						</Market>
						<Market Id="41" Name="1st Period Winner">
							<Bets>
								<Bet Id="38053443513696778" Name="2" Status="1" StartPrice="1.0" Price="2.36" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.880Z" />
								<Bet Id="38053432913696778" Name="X" Status="1" StartPrice="1.0" Price="4.85" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.880Z" />
								<Bet Id="38053443213696778" Name="1" Status="1" StartPrice="1.0" Price="2.27" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.880Z" />
							</Bets>
						</Market>
						<Market Id="42" Name="2nd Period Winner">
							<Bets>
								<Bet Id="38053440313696778" Name="1" Status="1" StartPrice="1.0" Price="2.26" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.906Z" />
								<Bet Id="38053440013696778" Name="2" Status="1" StartPrice="1.0" Price="2.35" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.906Z" />
								<Bet Id="38053436213696778" Name="X" Status="1" StartPrice="1.0" Price="4.96" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.906Z" />
							</Bets>
						</Market>
						<Market Id="45" Name="Under/Over 2nd Period" MainLine="4.5">
							<Bets>
								<Bet Id="107715977613696778" Name="Under" Line="4.5" BaseLine="4.5" Status="1" StartPrice="1.0" Price="1.88" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.895Z" />
								<Bet Id="107715968113696778" Name="Under" Line="3.5" BaseLine="3.5" Status="1" StartPrice="1.0" Price="3.02" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.895Z" />
								<Bet Id="82570180013696778" Name="Over" Line="4.5" BaseLine="4.5" Status="1" StartPrice="1.0" Price="1.78" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.895Z" />
								<Bet Id="135873452713696778" Name="Over" Line="3.5" BaseLine="3.5" Status="1" StartPrice="1.0" Price="1.31" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.895Z" />
							</Bets>
						</Market>
						<Market Id="21" Name="Under/Over 1st Period" MainLine="4.5">
							<Bets>
								<Bet Id="109769392113696778" Name="Over" Line="3.5" BaseLine="3.5" Status="1" StartPrice="1.0" Price="1.37" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.891Z" />
								<Bet Id="73554012313696778" Name="Under" Line="3.5" BaseLine="3.5" Status="1" StartPrice="1.0" Price="2.75" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.891Z" />
								<Bet Id="73553997013696778" Name="Under" Line="4.5" BaseLine="4.5" Status="1" StartPrice="1.0" Price="1.76" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.891Z" />
								<Bet Id="19036831813696778" Name="Over" Line="4.5" BaseLine="4.5" Status="1" StartPrice="1.0" Price="1.91" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.891Z" />
							</Bets>
						</Market>
						<Market Id="456" Name="Double Chance 1st Period">
							<Bets>
								<Bet Id="57957874213696778" Name="1X" Status="1" StartPrice="1.0" Price="1.55" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.889Z" />
								<Bet Id="18045289313696778" Name="X2" Status="1" StartPrice="1.0" Price="1.59" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.889Z" />
								<Bet Id="57957865613696778" Name="12" Status="1" StartPrice="1.0" Price="1.16" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.890Z" />
							</Bets>
						</Market>
						<Market Id="457" Name="Double Chance 2nd Period">
							<Bets>
								<Bet Id="70105484313696778" Name="12" Status="1" StartPrice="1.0" Price="1.15" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.905Z" />
								<Bet Id="70105492913696778" Name="1X" Status="1" StartPrice="1.0" Price="1.55" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.905Z" />
								<Bet Id="118360128813696778" Name="X2" Status="1" StartPrice="1.0" Price="1.6" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.905Z" />
							</Bets>
						</Market>
						<Market Id="59" Name="Next Goal">
							<Bets>
								<Bet Id="55297330913696778" Name="2" Line="1.0" BaseLine="1.0" Status="1" StartPrice="1.0" Price="1.89" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.892Z" />
								<Bet Id="17699871713696778" Name="No Goal" Line="1.0" BaseLine="1.0" Status="1" StartPrice="1.0" Price="9" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.892Z" />
								<Bet Id="55296799613696778" Name="1" Line="1.0" BaseLine="1.0" Status="1" StartPrice="1.0" Price="1.85" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.892Z" />
							</Bets>
						</Market>
						<Market Id="153" Name="Under/Over 1st Period - Home Team" MainLine="2.0">
							<Bets>
								<Bet Id="172885614113696778" Name="Over" Line="2.0" BaseLine="2.0" Status="1" StartPrice="1.0" Price="1.66" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.902Z" />
								<Bet Id="5765999513696778" Name="Under" Line="2.0" BaseLine="2.0" Status="1" StartPrice="1.0" Price="2.04" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.902Z" />
							</Bets>
						</Market>
						<Market Id="154" Name="Under/Over 2nd Period - Home Team" MainLine="2.5">
							<Bets>
								<Bet Id="66072344113696778" Name="Under" Line="2.5" BaseLine="2.5" Status="1" StartPrice="1.0" Price="1.6" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.886Z" />
								<Bet Id="72681029313696778" Name="Over" Line="2.5" BaseLine="2.5" Status="1" StartPrice="1.0" Price="2.13" ProviderBetId="145" LastUpdate="2024-09-09T17:39:06.886Z" />
							</Bets>
						</Market>
					</Markets>
				</Event>
				<Event FixtureId="13699549">
					<Fixture LastUpdate="2024-09-10T06:45:17.577Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:45:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53699772" Name="Portugal (fame)" Position="1" />
							<Participant Id="53736451" Name="Spain (hound)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13696781">
					<Fixture LastUpdate="2024-09-10T06:45:14.556Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="69749" Name="Short Football D1" />
						<StartDate>2024-09-10T06:45:00.000Z</StartDate>
						<Status>9</Status>
						<Participants>
							<Participant Id="53548349" Name="Volna (4X4)" Position="1" />
							<Participant Id="53551051" Name="Dynamo (4X4)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Markets>
						<Market Id="155" Name="Under/Over 1st Period - Away Team" MainLine="2.0">
							<Bets>
								<Bet Id="162483224313696781" Name="Over" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.67" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="102663203113696781" Name="Under" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="2.02" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
							</Bets>
						</Market>
						<Market Id="1" Name="1X2">
							<Bets>
								<Bet Id="99021027713696781" Name="2" Status="2" StartPrice="1.0" Price="2.11" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.817Z" />
								<Bet Id="180593022113696781" Name="X" Status="2" StartPrice="1.0" Price="6.97" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.817Z" />
								<Bet Id="57587366413696781" Name="1" Status="2" StartPrice="1.0" Price="2.21" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.817Z" />
							</Bets>
						</Market>
						<Market Id="64" Name="Asian Handicap 1st Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="154789272013696781" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.29" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="150994337813696781" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.8" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="125397102513696781" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.33" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="154677649713696781" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="3" StartPrice="1.0" Price="1.86" Settlement="3" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="151343131513696781" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="3" StartPrice="1.0" Price="1.26" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="121936580813696781" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="3" StartPrice="1.0" Price="3.16" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
							</Bets>
						</Market>
						<Market Id="2" Name="Under/Over" MainLine="9.5">
							<Bets>
								<Bet Id="132390381413696781" Name="Under" Line="9.5" BaseLine="9.5" Status="2" StartPrice="1.0" Price="1.64" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.807Z" />
								<Bet Id="118274131313696781" Name="Under" Line="8.5" BaseLine="8.5" Status="2" StartPrice="1.0" Price="2.16" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.807Z" />
								<Bet Id="210262691613696781" Name="Over" Line="9.5" BaseLine="9.5" Status="2" StartPrice="1.0" Price="2.06" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.807Z" />
								<Bet Id="210262682113696781" Name="Over" Line="8.5" BaseLine="8.5" Status="2" StartPrice="1.0" Price="1.59" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.807Z" />
							</Bets>
						</Market>
						<Market Id="3" Name="Asian Handicap" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="158261563713696781" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.53" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.810Z" />
								<Bet Id="97484832513696781" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.43" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.810Z" />
								<Bet Id="64097882613696781" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.39" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.810Z" />
								<Bet Id="161147644813696781" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.810Z" />
								<Bet Id="66021623913696781" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.79" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.810Z" />
								<Bet Id="197033952613696781" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="2.69" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.810Z" />
							</Bets>
						</Market>
						<Market Id="65" Name="Asian Handicap 2nd Period" MainLine="0.0 (0-0)">
							<Bets>
								<Bet Id="101341121913696781" Name="2" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.8" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.885Z" />
								<Bet Id="97085745713696781" Name="1" Line="1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.3" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.885Z" />
								<Bet Id="97197368013696781" Name="1" Line="0.0 (0-0)" BaseLine="0.0 (0-0)" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.885Z" />
								<Bet Id="71585771113696781" Name="2" Line="-1.0 (0-0)" BaseLine="1.0 (0-0)" Status="2" StartPrice="1.0" Price="3.11" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.885Z" />
								<Bet Id="67693582613696781" Name="1" Line="-1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="3.27" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.885Z" />
								<Bet Id="100992328213696781" Name="2" Line="1.0 (0-0)" BaseLine="-1.0 (0-0)" Status="2" StartPrice="1.0" Price="1.27" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.885Z" />
							</Bets>
						</Market>
						<Market Id="5" Name="Odd/Even">
							<Bets>
								<Bet Id="175906228213696781" Name="Odd" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.814Z" />
								<Bet Id="213342482913696781" Name="Even" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.814Z" />
							</Bets>
						</Market>
						<Market Id="6" Name="Correct Score">
							<Bets>
								<Bet Id="204360848713696781" Name="4-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="156574928013696781" Name="6-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="82643736913696781" Name="5-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="126389062413696781" Name="3-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="10109121013696781" Name="3-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="12129418613696781" Name="4-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="1986831513696781" Name="5-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="88080907313696781" Name="4-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="40294986613696781" Name="6-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="42315284213696781" Name="5-6" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="202340551113696781" Name="3-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="73964657213696781" Name="5-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="146499273113696781" Name="3-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="68527486813696781" Name="4-5" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
								<Bet Id="196903380713696781" Name="6-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.803Z" />
							</Bets>
						</Market>
						<Market Id="7" Name="Double Chance">
							<Bets>
								<Bet Id="30806742013696781" Name="1X" Status="2" StartPrice="1.0" Price="1.68" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.843Z" />
								<Bet Id="106341007513696781" Name="X2" Status="2" StartPrice="1.0" Price="1.62" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.843Z" />
								<Bet Id="30806731413696781" Name="12" Status="2" StartPrice="1.0" Price="1" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.843Z" />
							</Bets>
						</Market>
						<Market Id="100" Name="Correct Score 2nd Period">
							<Bets>
								<Bet Id="184573432913696781" Name="3-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="156340932713696781" Name="1-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="52691866613696781" Name="3-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="29985336413696781" Name="4-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="156875855513696781" Name="1-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="154855557913696781" Name="2-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="118032777613696781" Name="2-0" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="103916527513696781" Name="3-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="195184010613696781" Name="2-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="38575616513696781" Name="2-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="168971808013696781" Name="3-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="114527105213696781" Name="2-4" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="26479664013696781" Name="0-2" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="40595914113696781" Name="1-0" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="126623057713696781" Name="4-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="197204308213696781" Name="1-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="116012480013696781" Name="1-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="183088058113696781" Name="0-1" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
								<Bet Id="186593730513696781" Name="4-3" Status="2" StartPrice="1.0" Price="10" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.793Z" />
							</Bets>
						</Market>
						<Market Id="101" Name="Under/Over - Home Team" MainLine="4.5">
							<Bets>
								<Bet Id="33488878713696781" Name="Over" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.89" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.786Z" />
								<Bet Id="137358934713696781" Name="Under" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.77" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.786Z" />
							</Bets>
						</Market>
						<Market Id="9" Name="Correct Score 1st Period">
							<Bets>
								<Bet Id="198355350113696781" Name="2-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="41746956013696781" Name="2-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="190812926813696781" Name="2-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="160047195013696781" Name="3-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="110307908913696781" Name="4-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="53842908513696781" Name="0-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="32184235113696781" Name="3-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="202908879313696781" Name="4-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="200375647713696781" Name="3-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="170122849913696781" Name="0-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="158026897413696781" Name="2-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="114861438113696781" Name="2-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="15534753413696781" Name="1-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="55863206113696781" Name="1-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="112841140513696781" Name="3-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="60416735313696781" Name="1-4" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="102765485613696781" Name="0-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="46300485213696781" Name="4-2" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="172143147513696781" Name="1-0" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="43767253613696781" Name="3-1" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="100745188013696781" Name="1-3" Status="3" StartPrice="1.0" Price="10" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
							</Bets>
						</Market>
						<Market Id="102" Name="Under/Over - Away Team" MainLine="4.5">
							<Bets>
								<Bet Id="110314087813696781" Name="Under" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.83" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.790Z" />
								<Bet Id="87184484613696781" Name="Over" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.83" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.790Z" />
							</Bets>
						</Market>
						<Market Id="41" Name="1st Period Winner">
							<Bets>
								<Bet Id="43608304413696781" Name="1" Status="3" StartPrice="1.0" Price="2.36" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="43608304113696781" Name="2" Status="3" StartPrice="1.0" Price="2.28" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="43608301913696781" Name="X" Status="3" StartPrice="1.0" Price="4.84" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
							</Bets>
						</Market>
						<Market Id="42" Name="2nd Period Winner">
							<Bets>
								<Bet Id="43608298613696781" Name="X" Status="2" StartPrice="1.0" Price="4.95" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.840Z" />
								<Bet Id="43608307313696781" Name="1" Status="2" StartPrice="1.0" Price="2.35" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.840Z" />
								<Bet Id="43608307613696781" Name="2" Status="2" StartPrice="1.0" Price="2.27" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.840Z" />
							</Bets>
						</Market>
						<Market Id="45" Name="Under/Over 2nd Period" MainLine="4.5">
							<Bets>
								<Bet Id="92958432413696781" Name="Under" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.87" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.800Z" />
								<Bet Id="116461392013696781" Name="Over" Line="4.5" BaseLine="4.5" Status="2" StartPrice="1.0" Price="1.79" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.800Z" />
								<Bet Id="92958422913696781" Name="Under" Line="3.5" BaseLine="3.5" Status="2" StartPrice="1.0" Price="2.99" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.800Z" />
								<Bet Id="166200678113696781" Name="Over" Line="3.5" BaseLine="3.5" Status="2" StartPrice="1.0" Price="1.32" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.800Z" />
							</Bets>
						</Market>
						<Market Id="21" Name="Under/Over 1st Period" MainLine="4.5">
							<Bets>
								<Bet Id="156588717113696781" Name="Under" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="2.73" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="139203688713696781" Name="Over" Line="3.5" BaseLine="3.5" Status="3" StartPrice="1.0" Price="1.38" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="212321254613696781" Name="Over" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.92" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="156588701813696781" Name="Under" Line="4.5" BaseLine="4.5" Status="3" StartPrice="1.0" Price="1.75" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
							</Bets>
						</Market>
						<Market Id="456" Name="Double Chance 1st Period">
							<Bets>
								<Bet Id="209078920913696781" Name="X2" Status="3" StartPrice="1.0" Price="1.55" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="207527869213696781" Name="12" Status="3" StartPrice="1.0" Price="1.16" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="207527858613696781" Name="1X" Status="3" StartPrice="1.0" Price="1.59" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
							</Bets>
						</Market>
						<Market Id="457" Name="Double Chance 2nd Period">
							<Bets>
								<Bet Id="209821252313696781" Name="1X" Status="2" StartPrice="1.0" Price="1.59" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.820Z" />
								<Bet Id="209821241713696781" Name="12" Status="2" StartPrice="1.0" Price="1.15" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.820Z" />
								<Bet Id="72673502813696781" Name="X2" Status="2" StartPrice="1.0" Price="1.55" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.820Z" />
							</Bets>
						</Market>
						<Market Id="59" Name="Next Goal">
							<Bets>
								<Bet Id="37809630813696781" Name="No Goal" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="9" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.850Z" />
								<Bet Id="176541844413696781" Name="2" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="1.86" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.850Z" />
								<Bet Id="176541742113696781" Name="1" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="1.89" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.850Z" />
							</Bets>
						</Market>
						<Market Id="153" Name="Under/Over 1st Period - Home Team" MainLine="2.0">
							<Bets>
								<Bet Id="58862749913696781" Name="Under" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.96" Settlement="2" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
								<Bet Id="142275310513696781" Name="Over" Line="2.0" BaseLine="2.0" Status="3" StartPrice="1.0" Price="1.71" Settlement="1" ProviderBetId="145" LastUpdate="2024-09-10T06:46:11.781Z" />
							</Bets>
						</Market>
						<Market Id="154" Name="Under/Over 2nd Period - Home Team" MainLine="2.0">
							<Bets>
								<Bet Id="94969588613696781" Name="Over" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="1.62" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.882Z" />
								<Bet Id="28849762813696781" Name="Under" Line="2.0" BaseLine="2.0" Status="2" StartPrice="1.0" Price="2.1" ProviderBetId="145" LastUpdate="2024-09-10T06:45:47.882Z" />
							</Bets>
						</Market>
					</Markets>
				</Event>
				<Event FixtureId="13699556">
					<Fixture LastUpdate="2024-09-10T06:43:38.173Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="80034" Name="E-Football | FIFA 24 Cyber League (E) | 2x20 Minutes" />
						<StartDate>2024-09-10T06:45:00.000Z</StartDate>
						<Status>9</Status>
						<Participants>
							<Participant Id="53733034" Name="Paris Saint Germain (cancelo_6192)" Position="1" />
							<Participant Id="53732887" Name="Borussia Dortmund (osimhen_1029)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699557">
					<Fixture LastUpdate="2024-09-10T06:44:14.341Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="196" Name="China" />
						<League Id="75190" Name="Championship U19" />
						<StartDate>2024-09-10T06:30:00.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53744851" Name="Guangzhou Evergrande U19" Position="2" />
							<Participant Id="53744850" Name="Shanghai Jiading Huilong U19" Position="1" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699560">
					<Fixture LastUpdate="2024-09-10T06:44:53.449Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="196" Name="China" />
						<League Id="75190" Name="Championship U19" />
						<StartDate>2024-09-10T06:30:01.000Z</StartDate>
						<Status>2</Status>
						<Participants>
							<Participant Id="53744852" Name="Liaoning Tieren U19" Position="1" />
							<Participant Id="53659227" Name="Nantong Haimen Kediyuan U19" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699562">
					<Fixture LastUpdate="2024-09-10T06:45:34.066Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="68326" Name="E-Football | Adriatic League (E) | 2x5 Minutes" />
						<StartDate>2024-09-10T06:45:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53596414" Name="Italy (andrew)" Position="1" />
							<Participant Id="53522853" Name="France (obelix)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699567">
					<Fixture LastUpdate="2024-09-10T06:47:07.305Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T07:38:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727217" Name="Real Betis (pedro)" Position="1" />
							<Participant Id="53727748" Name="Real Sociedad (jacob17)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699568">
					<Fixture LastUpdate="2024-09-10T06:47:07.466Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78623" Name="E-Football | Valhalla Cup (E) | 8 Minutes" />
						<StartDate>2024-09-10T07:40:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53727216" Name="Rcd Mallorca (henry)" Position="1" />
							<Participant Id="53727224" Name="Sevilla Fc (bastony)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699571">
					<Fixture LastUpdate="2024-09-10T06:49:16.190Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:56:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="52404792" Name="Manchester City (KRaftVK) (E)" Position="1" />
							<Participant Id="52401941" Name="Tottenham (Flewless_phoenix) (E)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699572">
					<Fixture LastUpdate="2024-09-10T06:49:16.303Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:56:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="52910724" Name="liverpool (ecf_dava) esports" Position="1" />
							<Participant Id="52503497" Name="Manchester United (Labotryas)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699573">
					<Fixture LastUpdate="2024-09-10T06:49:16.436Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T07:08:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="52401941" Name="Tottenham (Flewless_phoenix) (E)" Position="1" />
							<Participant Id="52910724" Name="liverpool (ecf_dava) esports" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699574">
					<Fixture LastUpdate="2024-09-10T06:49:16.562Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="37386" Name="E-Football | Battle (E) | 8 Minutes" />
						<StartDate>2024-09-10T07:08:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="52449764" Name="Arsenal (Sane4ek8)" Position="1" />
							<Participant Id="52404792" Name="Manchester City (KRaftVK) (E)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699576">
					<Fixture LastUpdate="2024-09-10T06:49:42.827Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="65306" Name="USSR 3X3" />
						<StartDate>2024-09-10T06:55:00.000Z</StartDate>
						<Status>9</Status>
						<Participants>
							<Participant Id="53452967" Name="Holland (3X3)" Position="1" />
							<Participant Id="53453998" Name="Brazil (3X3)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699577">
					<Fixture LastUpdate="2024-09-10T06:49:42.569Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="78273" Name="E-Football | H2H GG League (E) | 8 Minutes" />
						<StartDate>2024-09-10T06:49:00.000Z</StartDate>
						<Status>1</Status>
						<Participants>
							<Participant Id="53695370" Name="Paris Saint Germain (lava)" Position="1" />
							<Participant Id="53700209" Name="Real Madrid (bullfrog)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">false</Data>
							<Data Name="WithLivescore">false</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
				</Event>
				<Event FixtureId="13699301">
					<Fixture LastUpdate="2024-09-10T06:14:15.820Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="38301" Name="E-Football | GT Leagues (E) | 12 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="52999635" Name="Barcelona FC (aibothard)" Position="1" />
							<Participant Id="53543346" Name="real madrid (jack)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="720">
							<Score Position="1">2</Score>
							<Score Position="2">3</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">3</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">0</Score>
								<Score Position="2">2</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="120" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="420" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="600" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="720" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">3</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="1">
								<Value Position="1">1</Value>
								<Value Position="2">1</Value>
								<Incidents>
									<Incident Period="10" IncidentType="1" Seconds="180" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">0</Score>
									</Incident>
									<Incident Period="10" IncidentType="1" Seconds="360" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Statistic>
							<Statistic Type="2">
								<Value Position="1">2</Value>
								<Value Position="2">3</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">22</Value>
								<Value Position="2">30</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">16</Value>
								<Value Position="2">31</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
				<Event FixtureId="13699306">
					<Fixture LastUpdate="2024-09-10T06:13:51.780Z">
						<Sport Id="6046" Name="Football" />
						<Location Id="248" Name="International" />
						<League Id="38301" Name="E-Football | GT Leagues (E) | 12 Minutes" />
						<StartDate>2024-09-10T06:00:00.000Z</StartDate>
						<Status>3</Status>
						<Participants>
							<Participant Id="53694801" Name="Girona (david)" Position="1" />
							<Participant Id="53672804" Name="Athletic Bilbao (furious)" Position="2" />
						</Participants>
						<FixtureExtraData>
							<Data Name="WithInPlay">true</Data>
							<Data Name="WithLivescore">true</Data>
						</FixtureExtraData>
						<Subscription>
							<Type>2</Type>
							<Status>1</Status>
						</Subscription>
					</Fixture>
					<Livescore>
						<Scoreboard Status="3" CurrentPeriod="100" Time="720">
							<Score Position="1">3</Score>
							<Score Position="2">2</Score>
						</Scoreboard>
						<Periods>
							<Period Type="100" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">3</Score>
								<Score Position="2">2</Score>
							</Period>
							<Period Type="10" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">1</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="10" IncidentType="27" Seconds="60" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">0</Score>
										<Score Position="2">1</Score>
									</Incident>
									<Incident Period="10" IncidentType="27" Seconds="180" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">1</Score>
									</Incident>
								</Incidents>
							</Period>
							<Period Type="20" IsFinished="true" IsConfirmed="true" SequenceNumber="0">
								<Score Position="1">2</Score>
								<Score Position="2">1</Score>
								<Incidents>
									<Incident Period="20" IncidentType="27" Seconds="600" ParticipantPosition="2" PlayerId="-1">
										<Score Position="1">1</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="660" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">2</Score>
										<Score Position="2">2</Score>
									</Incident>
									<Incident Period="20" IncidentType="27" Seconds="720" ParticipantPosition="1" PlayerId="-1">
										<Score Position="1">3</Score>
										<Score Position="2">2</Score>
									</Incident>
								</Incidents>
							</Period>
						</Periods>
						<Statistics>
							<Statistic Type="2">
								<Value Position="1">3</Value>
								<Value Position="2">2</Value>
							</Statistic>
							<Statistic Type="3">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
							<Statistic Type="4">
								<Value Position="1">26</Value>
								<Value Position="2">28</Value>
							</Statistic>
							<Statistic Type="5">
								<Value Position="1">28</Value>
								<Value Position="2">16</Value>
							</Statistic>
							<Statistic Type="8">
								<Value Position="1">1</Value>
								<Value Position="2">1</Value>
							</Statistic>
							<Statistic Type="10">
								<Value Position="1">0</Value>
								<Value Position="2">0</Value>
							</Statistic>
						</Statistics>
						<LivescoreExtraData />
					</Livescore>
				</Event>
			</Events>
		</Body>
	</Feed>'

	DECLARE @xmlParsed XML
	SELECT  @xmlParsed = CONVERT(XML, CONVERT(VARCHAR(MAX), @payload))

	DROP TABLE IF EXISTS #Snapshot 
	SELECT 
		Eventi.value('(@FixtureId)[1]', 'bigint')				FixtureId
		,Markets.value('(@Id)[1]', 'bigint')					MarketId
		,Bets.value('(@Id)[1]', 'bigint')						BetId
		,Bets.value('(@Name)[1]', 'varchar(150)')				BetName
		,Bets.value('(@Line)[1]', 'varchar(150)')				Line
		,Bets.value('(@BaseLine)[1]', 'varchar(150)')			BaseLine
		,Bets.value('(@Status)[1]', 'int')						BetStatus
		,Bets.value('(@StartPrice)[1]', 'money')				StartPrice
		,Bets.value('(@Price)[1]', 'money')						Price
		,Bets.value('(@ProviderBetId)[1]', 'int')				ProviderBetId
		,Bets.value('(@LastUpdate)[1]',	'datetime')				LastUpdate
		,Bets.value('(@SuspensionReason)[1]', 'varchar(14)')	SuspensionReason
		INTO #Snapshot 
			FROM @xmlParsed.nodes('//Event') AS EventXml(Eventi)
				OUTER Apply Eventi.nodes('Markets/Market') AS MarketXml(Markets)
				OUTER Apply Markets.nodes('Bets/Bet') AS BetXml(Bets)
			
	select * from #Snapshot 
end

GO

exec Feeds.sp_LSportsSnapshot null
