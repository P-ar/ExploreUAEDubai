USE [aspnet-DubaiExplore]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'79cf333c-afcd-4c8b-9cf6-b6779b80f975', N'admin', N'admin', N'f38b2c0f-396d-4231-9a27-53bb2f11964b')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1ed78b39-a24b-4951-9215-ed5db7de60d6', N'MahdhoodhaAmber@gmail.com', N'MAHDHOODHAAMBER@GMAIL.COM', N'MahdhoodhaAmber@gmail.com', N'MAHDHOODHAAMBER@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEHqO6Yas0iCRzr4541pwDHDd3nwlaFa7MRsdkz82ExurYoYkA0oq6ouRMeejmpDoJg==', N'KVZB5KOWAK3UML4C3GU54WH4R4ECOV7L', N'06bd3f57-ab97-4615-9ab7-3fd6fd3b784e', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'54460d7a-5071-4505-9772-ca0f0a668169', N'JaasirHoque@gmail.com', N'JAASIRHOQUE@GMAIL.COM', N'JaasirHoque@gmail.com', N'JAASIRHOQUE@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEMpyTc8nZP8kr7CmMcUDcfB+sSgmta1hb0YKy0bn9tl8UXZdBUSCBP4uL0yJBPMxEA==', N'63TBZQB2WYLZXHP7VTXLCFLSKPYAU2OS', N'0c6b9d99-f7a3-4e24-8171-3f77cda848e3', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'654d8511-b3f3-49ca-8339-54e38f5f4dcc', N'adminUAE@ExploreUAEDubai.com', N'ADMINUAE@EXPLOREUAEDUBAI.COM', N'adminUAE@ExploreUAEDubai.com', N'ADMINUAE@EXPLOREUAEDUBAI.COM', 1, N'AQAAAAEAACcQAAAAENLwQi+gDgAIoe9iTi/AVtcE2sum0ePJOKeZLP6YG9r3g3DR1cmlt2qg8PXDoTN5xA==', N'GCTON4VYGLPGONR6JIOU4NCFAED44FBJ', N'94f847c0-dfa7-4eb7-ad92-56a5776c60c7', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'654d8511-b3f3-49ca-8339-54e38f5f4dcc', N'79cf333c-afcd-4c8b-9cf6-b6779b80f975')
GO
SET IDENTITY_INSERT [dbo].[Attractions] ON 
GO
INSERT [dbo].[Attractions] ([AttractionID], [Name], [Description], [ContactNo]) VALUES (1, N'Burj Khalifa', N'The skyscraper the city is most famous for, the Burj Khalifa truly is an incredible building. It’s 828 metres tall and clad with 26,000 glass panels for a mirror-finish. Take one of the world’s fastest elevators to the 124th floor to marvel at the spaghetti mess of highways and comparatively tiny buildings below. Entry is pricey, but the views are worth it – especially at sunset.', N'+9713531379')
GO
INSERT [dbo].[Attractions] ([AttractionID], [Name], [Description], [ContactNo]) VALUES (2, N'Dubai Mall', N'Yet another record-breaker, Dubai Mall is the world’s largest shopping centre at a whopping 13 million square feet in size. It’s not just about shopping here, though: there’s an aquarium, ice rink, Sonic the Hedgehog theme park, cinemas and a vast food court.', N'+9713558966')
GO
INSERT [dbo].[Attractions] ([AttractionID], [Name], [Description], [ContactNo]) VALUES (3, N'Atlantis, The Palm', N'Atlantis, The Palm is one of Dubai’s most iconic buildings, soaring high above the man-made Palm Island. Its underwater theme and on-site water park make it a brilliant upmarket family resort.', N'+9713558111')
GO
INSERT [dbo].[Attractions] ([AttractionID], [Name], [Description], [ContactNo]) VALUES (4, N'UAE history at Dubai Museum', N'Dubais excellent museum is housed in the Al-Fahidi Fort, built in 1787 to defend Dubai Creek. The forts walls are built out of traditional coral-blocks and held together with lime. The upper floor is supported by wooden poles, and the ceiling is constructed from palm fronds, mud, and plaster.', N'+9713558722')
GO
INSERT [dbo].[Attractions] ([AttractionID], [Name], [Description], [ContactNo]) VALUES (5, N'Dubai Frame', N'Sitting slap-bang between Dubai"s older neighborhoods clustered around the creek and the city"s modern sprawl, this ginormous 150-meter-high picture frame is one of Dubai"s latest sights.Inside, a series of galleries whisk you through the citys history and explore Emirati heritage before you travel up to the Sky Deck, where there are fantastic panoramas of both old and new Dubai to be snapped on the viewing platforms.', N'+9713558112')
GO
INSERT [dbo].[Attractions] ([AttractionID], [Name], [Description], [ContactNo]) VALUES (6, N'Theater at Dubai Opera', N'For nighttime attractions, look no further. Opened in mid-2016, Dubai"s classy new opera building is the centerpiece of the waterfront Opera District in downtown Dubai and set to become the city"s major cultural hub and main entertainment venue.The Dubai Opera hosts a year-round program of famous musical theater productions, concerts by world-class musicians, opera, ballet, and classical music, as well as smaller productions, comedy nights, and concerts.', N'+9713441922')
GO
INSERT [dbo].[Attractions] ([AttractionID], [Name], [Description], [ContactNo]) VALUES (7, N'Miracle Garden', N'This is the zaniest garden ever.Not content with constructing the world"s largest buildings and malls, Dubai has created the world"s largest flower garden, spanning 2,000 square meters and home to a reputed 100 million flowers.', N'+9713551366')
GO
SET IDENTITY_INSERT [dbo].[Attractions] OFF
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON 
GO
INSERT [dbo].[Bookings] ([BookingID], [BookingDate], [UserID], [AttractionID]) VALUES (1, CAST(N'2021-05-10T01:05:00.0000000' AS DateTime2), N'JaasirHoque@gmail.com', 1)
GO
INSERT [dbo].[Bookings] ([BookingID], [BookingDate], [UserID], [AttractionID]) VALUES (2, CAST(N'2021-05-10T01:07:00.0000000' AS DateTime2), N'JaasirHoque@gmail.com', 3)
GO
SET IDENTITY_INSERT [dbo].[Bookings] OFF
GO
SET IDENTITY_INSERT [dbo].[Supports] ON 
GO
INSERT [dbo].[Supports] ([SupportID], [Question], [Answer]) VALUES (1, N'What is Price of the pass?', N'The pass is absolutely free for permanent residents (not tourists) of Dubai.')
GO
INSERT [dbo].[Supports] ([SupportID], [Question], [Answer]) VALUES (2, N'What is the validity of the pass?', N'The pass is valid for the same day it issues till 11:59:59pm')
GO
INSERT [dbo].[Supports] ([SupportID], [Question], [Answer]) VALUES (3, N'What is included in the pass?', N'This is just the free check-in pass, you need not to pay any entry ticket cost. This pass does not include any food and shopping credits.')
GO
INSERT [dbo].[Supports] ([SupportID], [Question], [Answer]) VALUES (4, N'Who can get this pass?', N'This pass is only for permanent residents (not tourists) of Dubai. You need to attach your ID proof along this pass at the check-in point.')
GO
INSERT [dbo].[Supports] ([SupportID], [Question], [Answer]) VALUES (5, N'How many places we can visit with this pass?', N'The pass is used to visit only one attraction or place.')
GO
INSERT [dbo].[Supports] ([SupportID], [Question], [Answer]) VALUES (6, N'How many passes one user can get?', N'One user can have maximum of 2 passes in one day.')
GO
SET IDENTITY_INSERT [dbo].[Supports] OFF
GO
SET IDENTITY_INSERT [dbo].[VisitorDetails] ON 
GO
INSERT [dbo].[VisitorDetails] ([VisitorDetailID], [Name], [UserID], [Address], [ContactNo], [Extension]) VALUES (1, N'Jaasir el Hoque', N'JaasirHoque@gmail.com', N'Box No. 40609, Dubai', N'+9712225445', N'.png')
GO
SET IDENTITY_INSERT [dbo].[VisitorDetails] OFF
GO
