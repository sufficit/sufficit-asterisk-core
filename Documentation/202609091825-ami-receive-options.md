# Opções de recepção AMI — 2026-09-09 18:25 -03

ManagerConnectionParameters ganhou ReceivePacketCapacity, ReceiveLineCapacity,
ReceiveMaxLineChars e ReceiveMaxPacketChars, validados em conjunto e considerados
em Equals/GetHashCode. Zero em todos preserva o comportamento anterior.
AGISocketOptions possui limites opcionais da fila de linhas e de caracteres por linha.
Defaults AGI não mudaram; AMISocketManager passa os limites apenas quando configurados.

Contrato completo e validações:
[Manager](../../sufficit-asterisk-manager/Documentation/202609091825-bounded-ami-receive.md).
Mudança local, não publicada. Testes cobrem opções inválidas e manutenção dos defaults.
