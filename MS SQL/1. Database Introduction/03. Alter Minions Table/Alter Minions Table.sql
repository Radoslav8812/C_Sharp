ALTER TABLE [Minions]
ADD [TownId] INT 

ALTER TABLE [Minions]
ADD FOREIGN KEY ([TownId]) REFERENCES [Towns]([Id])