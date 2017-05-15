CREATE TABLE [dbo].[Ticket] (
    [ticket_id]  INT      NOT NULL,
    [prioridade] TINYINT  NULL,
    [recdate]    DATETIME NULL,
    [requester]  INT      NULL,
    [horas]      INT      NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([ticket_id] ASC)
);

