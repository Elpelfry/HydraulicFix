﻿using HydraulicFix.Data;
using Microsoft.EntityFrameworkCore;
using Shared.Interfaces;
using Shared.Models;

namespace HydraulicFix.Services;

public class VentasService(ApplicationDbContext _contexto): IHydraulic<Ventas>
{
    public async Task<List<Ventas>> GetAllObject()
    {
        return await _contexto.Ventas.Include(v => v.VentasDetalle).ToListAsync();
    }

    public async Task<Ventas> GetObject(int id)
    {
        return (await _contexto.Ventas.Include(v => v.VentasDetalle).FirstOrDefaultAsync(v => v.VentaId == id))!;
    }

    public async Task<Ventas> AddObject(Ventas type)
    {
        _contexto.Ventas.Add(type);
        await _contexto.SaveChangesAsync();
        return type;
    }

    public async Task<bool> UpdateObject(Ventas type)
    {
        await _contexto.VentasDetalle.Where(v => v.VentaId == type.VentaId).ExecuteDeleteAsync();
        foreach (var item in type.VentasDetalle)
            _contexto.VentasDetalle.Add(item);

        _contexto.Entry(type).State = EntityState.Modified;
        return await _contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteObject(int id)
    {
        var venta = await _contexto.Ventas.FindAsync(id);
        if (venta == null)
            return false;
        await _contexto.VentasDetalle.Where(v => v.VentaId == id).ExecuteDeleteAsync();
        _contexto.Ventas.Remove(venta);
        return await _contexto.SaveChangesAsync() > 0;
    }
}

