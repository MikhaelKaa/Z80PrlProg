// Header: z80 ram io
// File Name: z80_port.h
// Author: Mikhail Kaa
// Date: 22.03.2024

#include "z80_ram.h"
#include "z80_bus_io.h"
#include "z80_ram_rw.h"

uint8_t z80_port_read(uint16_t Adr) {
    uint8_t Data = 0;
    if(!z80_is_stopped) return Data;
    // WR в высокий уровень.
    LL_GPIO_SetOutputPin(WR_GPIO_Port, WR_Pin);
    RAMMDELAY(10);
    // Установим адрес на шине.
    LL_GPIO_WriteOutputPort(RAMM_ADR_PORT, Adr);
    RAMMDELAY(10);
    // Установим сигнал IORQ в низкий уровень.
    LL_GPIO_ResetOutputPin(IORQ_GPIO_Port, IORQ_Pin);
    RAMMDELAY(10);
    // Установим сигнал RD в низкий уровень.
    LL_GPIO_ResetOutputPin(RD_GPIO_Port, RD_Pin);
    RAMMDELAY(10);
    // Вычитываем данные с шины данных.
    Data = (uint8_t)(GPIOA->IDR);
    // Установим сигнал IORQ в высокий уровень.
    LL_GPIO_SetOutputPin(IORQ_GPIO_Port, IORQ_Pin);

    return Data;
}

void z80_port_write(uint16_t Adr, uint8_t Data) {
    if(!z80_is_stopped) return;
    RAMMDELAY(25);
    // Установим сигнал RD в высокий уровень.
    LL_GPIO_SetOutputPin(RD_GPIO_Port, RD_Pin);

    RAMMDELAY(5); // TODO: Возможно задерки можно уменшить, а некоторые вообще убрать.
    // Установим адрес на шине.
    LL_GPIO_WriteOutputPort(RAMM_ADR_PORT, Adr);
    RAMMDELAY(25);
    // Установим данные на шине.
    uint32_t temp = GPIOA->ODR;
    temp &= 0xffffff00;
    temp = temp | Data;
    GPIOA->ODR = temp;
    RAMMDELAY(25);
    // Установим сигнал IORQ в низкий уровень.
    LL_GPIO_ResetOutputPin(IORQ_GPIO_Port, IORQ_Pin);
    // WR в низкий уровень.
    LL_GPIO_ResetOutputPin(WR_GPIO_Port, WR_Pin);
    RAMMDELAY(25);
    // WR в высокий уровень.
    LL_GPIO_SetOutputPin(WR_GPIO_Port, WR_Pin);
    // Установим сигнал IORQ в высокий уровень.
    LL_GPIO_SetOutputPin(IORQ_GPIO_Port, IORQ_Pin);
    RAMMDELAY(25);
    // Установим сигнал IORQ в низкий уровень.
    LL_GPIO_ResetOutputPin(IORQ_GPIO_Port, IORQ_Pin);
    // WR в низкий уровень.
    LL_GPIO_ResetOutputPin(WR_GPIO_Port, WR_Pin);
    RAMMDELAY(25);
    // WR в высокий уровень.
    LL_GPIO_SetOutputPin(WR_GPIO_Port, WR_Pin);
    // Установим сигнал IORQ в высокий уровень.
    LL_GPIO_SetOutputPin(IORQ_GPIO_Port, IORQ_Pin);
}
